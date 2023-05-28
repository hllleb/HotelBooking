using HotelBookingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.Data;

public class HotelBookingDbContext : DbContext
{
    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Hotel> Hotels { get; set; }
    
    public DbSet<Reservation> Reservations { get; set; }

    public DbSet<Room> Rooms { get; set; }

    public DbSet<User> Users { get; set; }
}