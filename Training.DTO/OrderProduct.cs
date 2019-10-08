using System;
using System.Collections.Generic;
using System.Text;

namespace Training.DTO
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
