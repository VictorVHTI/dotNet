﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Description { get; set; }
    }
}
