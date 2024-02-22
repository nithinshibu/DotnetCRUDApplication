using ASPDotNetCRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCRUDApp.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }
    }
}
