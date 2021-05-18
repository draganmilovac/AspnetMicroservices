﻿using Microsoft.EntityFrameworkCore;
using Ordering.Application.Contracts.Persistence;
using Ordering.Domain.Entities;
using Ordering.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class OrderRepositor : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepositor(OrderContext dbContext) : base (dbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByUsername(string username)
        {
           return await _dbContext.Orders.Where(o => o.UserName == username).ToListAsync();         
        }
    }
}
