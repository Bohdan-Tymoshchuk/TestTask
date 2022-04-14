using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasIndex(x => x.Email)
                .IsUnique();
        }
    }
}
