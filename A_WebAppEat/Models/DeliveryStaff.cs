﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSEat.Models
{
    public class DeliveryStaff
    {
        public int delivery_staff_Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int cityCode { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}