
using ApiBackEnd.CultureApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBackEnd.CultureApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}