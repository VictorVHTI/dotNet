using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{
    public static class ProductExtension
    {
        public static DTO.Product toDTO(this Models.Product p)
        {
            return new DTO.Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description
    };
        }

        public static Models.Product ToDatabaseModel(this DTO.Product p)
        {
            return new Models.Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description
            };
        }
    }
}
