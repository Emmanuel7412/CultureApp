using ApiBackEnd.CultureApp.Data.Entities;
using ApiBackEnd.CultureApp.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiBackEnd.CultureApp.Data.Repositories
{
    public class DPUsers : IDPUsers
    {
        private readonly DataContext _db;

        public DPUsers(DataContext context)
        {
            _db = context;
        }

        public async Task<bool> AddUser(User user)
        {
            _db.Users.Add(user);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> UserExists(string email)
        {
            return await GetAll().AnyAsync(u => u.Email == email.ToLower());
        }

        private IQueryable<User> GetAll()
        {
            return _db.Users;
        }
    }
}