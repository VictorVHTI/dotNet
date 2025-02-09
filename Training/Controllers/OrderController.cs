﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Training.API.Operations;
using Microsoft.Extensions.DependencyInjection;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceProvider _IoC;

        public OrderController(IServiceProvider services)
        {
            _IoC = services;
        }

        [HttpGet]
        public async Task<List<DTO.Order>> GetUsers()
        {
            return await _IoC.GetService<GetOrders>().Execute();
        }
    }
}