﻿using Microsoft.EntityFrameworkCore;
using BilgiLigiSecurityApi.DataLayer.Entities;

namespace BilgiLigiSecurityApi.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISecurityDbContext context;
        public UserRepository(ISecurityDbContext _dbContext)
        {
            context = _dbContext;
        }

        public async Task<int> AddUser(User user)
        {
            try
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
                return user.Id;
            }
            catch (Exception ex) {
                return -1;
            }
        }

        public async Task<List<User>> GetAll()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<bool> UpdateUser(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
