﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.DTO;

namespace Training.API.Contracts
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAll();
    }
}
