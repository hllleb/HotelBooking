using HotelBookingApp.Data;
using HotelBookingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ReservationBookingApp.Services;

public class ReservationService
{
    private readonly HotelBookingDbContext dbContext;

    public ReservationService(HotelBookingDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
    {
        return await this.dbContext.Reservations.ToListAsync();
    }

    public async Task<Reservation?> GetReservationAsync(int id)
    {
        return await this.dbContext.FindAsync<Reservation>(id);
    }

    public async Task<bool> AddReservationAsync(Reservation reservation)
    {
        await this.dbContext.AddAsync(reservation);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> RemoveReservationAsync(int id)
    {
        var reservation = this.dbContext.Find<Reservation>(id);
        if (reservation is null)
        {
            return false;
        }
        
        this.dbContext.Remove(reservation);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateReservationAsync(Reservation reservation)
    {
        this.dbContext.Update(reservation);
        return await this.dbContext.SaveChangesAsync() > 0;
    }
}