using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetOrders
    {
        private readonly IOrderRepository _OrderRepository;
        public GetOrders(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public async Task<List<DTO.Order>> Execute()
        {
            return await _OrderRepository.GetAll();
        }

    }
}
