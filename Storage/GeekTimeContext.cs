using Microsoft.EntityFrameworkCore;
using GeekTime.Storage.Entity;

namespace GeekTime.Storage
{
    public class GeekTimeContext:DbContext
    {
        public GeekTimeContext(DbContextOptions<GeekTimeContext> options):base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Events> Events { get; set; }
    }

}