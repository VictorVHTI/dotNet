using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrderProducts
    {
        private readonly IOrdersProductsRepository _OrdersProductsRepository;

        public GetOrderProducts(IOrdersProductsRepository orderProductsRepository)
        {
            _OrdersProductsRepository = orderProductsRepository;
        }

        public async Task<List<DTO.OrderProduct>> Execute()
        {
            return await _OrdersProductsRepository.GetAll();
        }

    }
}
