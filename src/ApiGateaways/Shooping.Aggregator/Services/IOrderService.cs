﻿using Shooping.Aggregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shooping.Aggregator.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
