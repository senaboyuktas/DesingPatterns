using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; initial catalog=DesignPattern1; integrated security=true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
