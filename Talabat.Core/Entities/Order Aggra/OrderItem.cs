﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities.Core_Aggra
{
    public class OrderItem:BaseEntity
    {
        public ProductItemOrder Product { get; set; }
        public int Quantity { get; set; }
        
        public decimal Price { get; set; }

    }
}