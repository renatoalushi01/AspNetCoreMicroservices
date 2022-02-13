using Shooping.Aggregator.Models;
using System.Threading.Tasks;

namespace Shooping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
