﻿using Basket.API.Entities;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCard> GetBasket(string userName);
        Task<ShoppingCard> UpdateBasket(ShoppingCard basket);
        Task DeleteBasket(string userName);
    }
}
