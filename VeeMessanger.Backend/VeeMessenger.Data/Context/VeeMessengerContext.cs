using Microsoft.EntityFrameworkCore;
using VeeMessenger.Data.Entities;
using VeeMessenger.Data.EntityConfigurations;

namespace VeeMessenger.Data.Context
{
    public class VeeMessengerContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserTempData> UsersTempData { get; set; }

        public DbSet<RefreshSession> RefreshSessions { get; set; }

        public VeeMessengerContext(DbContextOptions<VeeMessengerContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserTempDataConfiguration());
            modelBuilder.ApplyConfiguration(new RefreshSessionConfiguration());
        }
    }
}
