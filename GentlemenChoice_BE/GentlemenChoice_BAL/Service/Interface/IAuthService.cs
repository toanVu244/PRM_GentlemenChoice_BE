﻿using GentlemenChoice_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface IAuthService
    {
        Task<Customer?> AuthenticateCustomer(string email, string hashedPassword);

        Task<string> GenerateAccessTokenForCustomer(Customer customer);
        Task<string> GenerateAccessTokenForAdmin();
    }
}
