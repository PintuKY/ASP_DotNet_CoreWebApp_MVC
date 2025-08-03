using Microsoft.EntityFrameworkCore;
using ASPDotNet_CORE_WebApplication.Models;
namespace ASPDotNet_CORE_WebApplication.AddDbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :  base(options) { }
        public DbSet<Employees> TblEmployees { get; set; } 
    }
}
