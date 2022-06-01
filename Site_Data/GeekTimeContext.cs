//контекст 
using Microsoft.EntityFrameworkCore;
using GeekTime.Models;

namespace GeekTime.Site_Data
{
    public class GeekTimeContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<ConsoleGame> ConsoleGames { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TimetableRent> TimetableRents { get; set; }
        public GeekTimeContext(DbContextOptions<GeekTimeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

}
