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
    public class OrdersProductsRepository : IOrdersProductsRepository
    {
        private readonly StoreContext _StoreContext;
        public OrdersProductsRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.OrderProduct>> GetAll()
        {
            var orderProduct = await _StoreContext.OrderProducts.ToListAsync();
            return orderProduct.Select(op => op.ToDTO()).ToList();
        }
    }
}
