﻿using GentlemenChoice_BE.Controllers;
using GentlemenChoice_BAL.ModelView;
using GentlemenChoice_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface IOrderService
    {
        Task<int> ValidateItemInCart(List<OrderProductDto> cartItems);
        Task<string> CreateOrder(List<OrderProductDto> cartItems);
        Task<List<OrderDtoResponse>> GetAllOrders();
        Task<List<OrderDtoResponse>> GetOrdersByCustomerId(int CustomerId);
        Task<OrderDtoResponse?> GetOrderById(int id);
        Task<Order?> _getOrderById(int id);
        Task UpdateOrderStatus(Order order);
    }
}
