using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(
             "Server=localhost;" +
             "Port=5432;" +
             "Database=api;" +
             "User Id=postgres;" +
             "Password=root;");
        
    }
}
