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
        public DbSet<Task> Tasks{get;set;}
        public DbSet<TaskAttack> TaskAttacks {get;set;}
        public DbSet<TaskTransport> taskTransports  { get; set; }
    }
    
}