using Catalog.API.Data;
using Catalog.API.Entities;
using Catalog.API.Extentions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context;
        }

        public async Task<PaginationResult<Product>> GetProducts(int pageNumber)
        {
            var pageSize = 5;
            pageNumber = (pageNumber - 1) * pageSize;
            var paginationResult = new PaginationResult<Product>
            {
                Data = await _context
                          .Products
                          .Find(x => true)
                          .Skip(pageNumber)
                          .Limit(pageSize)
                          .ToListAsync(),
                Total = await _context
                          .Products
                          .Find(x => true)
                          .CountDocumentsAsync()
            };


            return paginationResult;
        }

        public async Task<Product> GetProduct(string id)
        {
            return await _context
                         .Products
                         .Find(x => x.Id == id)
                         .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Name, name);

            return await _context
                            .Products
                            .Find(filter)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Category, categoryName);

            return await _context
                            .Products
                            .Find(filter)
                            .ToListAsync();
        }
        public async Task CreateProduct(Product product)
        {
            await _context.Products.InsertOneAsync(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var updateResult = await _context
                                        .Products
                                        .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> DeleteProduct(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.Id, id);

            DeleteResult deleteResult = await _context
                                                .Products
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
