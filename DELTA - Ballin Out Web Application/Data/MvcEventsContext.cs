using Microsoft.EntityFrameworkCore;
using DELTA___Ballin_Out_Web_Application.Models;

namespace DELTA___Ballin_Out_Web_Application.Data
{
    public class MvcEventsContext : DbContext
    {
        public MvcEventsContext(DbContextOptions<MvcEventsContext> options)
            : base(options)
        {
        }

        public DbSet<Events> Events { get; set; }
    }
}
