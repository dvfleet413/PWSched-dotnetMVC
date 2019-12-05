using Microsoft.EntityFrameworkCore;
using PWSched_dotnet_mvc.Models;

namespace PWSched_dotnet_mvc.Data
{
    public class PWSchedContext : DbContext
    {
        public PWSchedContext(DbContextOptions<PWSchedContext> options)
            : base(options)
        {
        }

        public DbSet<Shift> Shift { get; set; }
    }
}