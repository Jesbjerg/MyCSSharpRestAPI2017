﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL.Entities
{
    public class Address
    {
        public int Id { get; set;}
        public string Street { get; set; }
        
        public string Number { get; set; }

        public string City { get; set; }

        List<Customer> Customer { get; set; }
    }
}