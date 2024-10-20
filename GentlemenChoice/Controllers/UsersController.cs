﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GentlemenChoice.Data.DBContext;
using GentlemenChoice.Data.Models;
using GentlemenChoice.Service;
using GentlemenChoice.Service.Base;
using GentlemenChoice.Common;

namespace GentlemenChoice.APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService) => _userService = userService;

        // GET: api/Users
        [HttpGet]
        public async Task<IServiceResult> GetUsers()
        {
            return await _userService.GetAll();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IServiceResult> GetUser(int id)
        {
            var user = await _userService.GetById(id);

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IServiceResult> PutUser(int id, User user)
        {
            return await _userService.Save(user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IServiceResult> PostUser(User user)
        {
            return await _userService.Save(user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IServiceResult> DeleteUser(int id)
        {
            return await _userService.DeleteById(id);
        }

        private bool UserExists(int id)
        {
            return _userService.GetById(id) != null;
        }
    }
}
