using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        //public IList<OrderProduct> OrderProducts { get; set; }
    }
}
