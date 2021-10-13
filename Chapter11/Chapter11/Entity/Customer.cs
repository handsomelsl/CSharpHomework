﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11
{
    [Serializable]
    public class Customer
    {
        
        public string Name { get; set; }
        public int CustomerId { get; set; }

        //public List<Order> Orders { get; set; }


        public override string ToString()
        {
            return $"Customer's name:{Name}";
        }
    }
}
