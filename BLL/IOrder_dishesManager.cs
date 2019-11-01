﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BLL
{
    public interface IOrder_dishesManager
    {
        IOrder_dishesDB HotelsDB { get; }

        List<Order_dishes> GetOrders_dishes(int order_id);
        List<Order_dishes> GetOrders_dishes_ds(int delivery_staff_id);
        Order_dishes GetOrder_dishes(int order_id, int dishes_id);
        Order_dishes AddOrder_dishes(Order_dishes order_dishes);
        int UpdateOrder_dishes(Order_dishes order_dishes);
        int DeleteOrder_dishes(int order_id, int dishes_id);
    }
}