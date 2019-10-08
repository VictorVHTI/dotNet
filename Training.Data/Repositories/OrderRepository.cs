using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;

namespace Training.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreContext _StoreContext;
        public OrderRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.Order>> GetAll()
        {
            var orders = await _StoreContext.Orders.ToListAsync();
            return orders.Select(o => o.ToDTO()).ToList();
        }
    }
}
