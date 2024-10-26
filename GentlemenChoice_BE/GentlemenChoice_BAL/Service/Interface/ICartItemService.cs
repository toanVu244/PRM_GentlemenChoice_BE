﻿using GentlemenChoice_BAL.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface ICartItemService
    {
        Task<bool> AddToCart(CartItemDtoRequest request);

        Task<List<CartItemDtoResponse>> GetCartItemsByCustomerId(int CustomerId);

        Task<bool> DeleteItemInCart(int id);

        Task<int> UpdateItemQuantityInCart(int id, int quantity);
    }
}
