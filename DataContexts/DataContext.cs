using LearningApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace LearningApplication
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("TestDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasKey(x => x.Id);
            modelBuilder.Entity<Response>().HasKey(x => x.Id);
            modelBuilder.Entity<Request>().HasKey(x => x.Name);
            //modelBuilder.Entity<Request>().HasKey(x => x.Email);
        }

        public DbSet<Contact> contacts { get; set; }
        public DbSet<Response> responses { get; set; }

        public DbSet<Request> requests { get; set; }



    }
}
