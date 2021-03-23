﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonohagoWebApp.Models;
using KonohagoWebApp.Repository.Interfaces;
using Npgsql;
namespace KonohagoWebApp.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
        Task AddUser(User user, string password);

        bool CheckUser(string email, string nickname);
        bool CheckUserPass(string email, string password);
        Task<User> GetUserById(int id);
        Task UpdateUserAsync(User user, int id);
        List<User> GetAllUser();
    }
}
