using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class OrderProductExtension
    {
        public static DTO.OrderProduct ToDTO(this Models.OrderProduct op)
        {
            return new DTO.OrderProduct
            {
                Id = op.Id,
                ProductID = op.ProductID,
                Quantity = op.Quantity,
                Order = op.Order.ToDTO(),
            };
        }

        public static Models.OrderProduct ToDatabaseModel(this DTO.OrderProduct op)
        {
            return new Models.OrderProduct
            {
                Id = op.Id,
                Quantity = op.Quantity,
                Order = op.Order.ToDatabaseModel(),
                Product = op.Product.ToDatabaseModel()
            };

        }
    }
}
