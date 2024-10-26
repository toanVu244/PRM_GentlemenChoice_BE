using AutoMapper;
using GentlemenChoice_BAL.ModelView;
using GentlemenChoice_BE.Controllers;
using GentlemenChoice_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductDtoResponse>().ReverseMap();
            CreateMap<Product, ProductDtoRequest>().ReverseMap();
            CreateMap<Category, CategoryDtoResponse>().ReverseMap();
            CreateMap<Category, CategoryDtoRequest>().ReverseMap();
            CreateMap<Customer, CustomerDtoResponse>().ReverseMap();
            CreateMap<Customer, CustomerDtoRequest>().ReverseMap();
            CreateMap<CartItem, CartItemDtoRequest>().ReverseMap();
            CreateMap<CartItem, CartItemDtoResponse>().ReverseMap();
            CreateMap<ChatRequest, MessageDtoRequest>().ReverseMap();
            CreateMap<ChatRequest, MessageDtoResponse>().ReverseMap();
            CreateMap<Order, OrderDtoResponse>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDtoResponse>().ReverseMap();
            CreateMap<Payment, PaymentResponse>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDtoRequest>().ReverseMap();
        }
    }
}
