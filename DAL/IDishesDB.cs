﻿using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDishesDB
    {
        IConfiguration Configuration { get; }
        List<Dishes> GetDishes(int idRestaurant);
        Dishes GetDish(int id);
       
    }
}
