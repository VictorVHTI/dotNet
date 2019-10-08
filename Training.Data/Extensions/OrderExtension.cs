using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Extensions
{

    public static class OrderExtension
    {
        public static DTO.Order ToDTO(this Models.Order o)
        {
            return new DTO.Order
            {
                Id = o.Id,
                UserID = o.UserId
            };
        }

        public static Models.Order ToDatabaseModel(this DTO.Order o)
        {
            return new Models.Order
            {
                Id = o.Id,
                UserId = o.UserID
            };
        }
    }
   
}
