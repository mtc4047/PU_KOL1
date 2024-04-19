using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Student> Products { get; set; }
        public DbSet<Grupa> ProductGroups { get; set; }
        public DbSet<Historia> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PU_KOL1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Student());
            modelBuilder.ApplyConfiguration(new Historia());
            modelBuilder.ApplyConfiguration(new Grupa());
        }
    }
}
