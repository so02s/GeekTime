//контекст 
using Microsoft.EntityFrameworkCore;
using GeekTime.Models;

namespace GeekTime.Site_Data
{
    public class GeekTimeContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<Comics> Comics { get; set; }
        public DbSet<ConsoleGames> ConsoleGames { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rates> Rates { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<TimetableRent> TimetableRents { get; set; }
        public GeekTimeContext(DbContextOptions<GeekTimeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

}
