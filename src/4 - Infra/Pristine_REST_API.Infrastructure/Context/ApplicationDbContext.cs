using Microsoft.EntityFrameworkCore;
using Pristine_REST_API.Domain.Entities;

namespace Pristine_REST_API.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.EmpNo)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpAddressLine1)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpAddressLine2)
                .HasColumnType("nvarchar(100)");

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpAddressLine3)
                .HasColumnType("nvarchar(100)");
        }
    }
}
