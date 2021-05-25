﻿using FundRaiser_Team5.Data;
using FundRaiser_Team5.Interfaces;
using FundRaiser_Team5.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team5.Services
{
    public class UserService: IUserInterface
    {
        private readonly FrDbContext _context;
        //private readonly ILogger<UserService> _logger;

        public UserService(FrDbContext context, /*ILogger<UserService> logger*/)
        {
            _context = context;
            //_logger = logger;
        }
        public Task<List<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> CreateUserAsync(OptionUser options)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
