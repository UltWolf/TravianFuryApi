using ApiFury.Entities;
using ApiFury.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFury.Services
{
    
        public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<MyVillages> MyVillages { get; set; }
        public DbSet<Villages> Villages { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
}