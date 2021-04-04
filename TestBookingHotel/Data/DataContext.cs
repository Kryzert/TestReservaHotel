using Microsoft.EntityFrameworkCore;
using ReservasHotel.Models;

namespace ReservasHotel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Bookings> Bookings{get; set;}
        public DbSet<Rooms> Rooms{get; set;}

    }
}