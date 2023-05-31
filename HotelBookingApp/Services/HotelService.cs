using HotelBookingApp.Data;
using HotelBookingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.Services;

public class HotelService : IHotelService
{
    private readonly HotelBookingDbContext dbContext;

    public HotelService(HotelBookingDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        return await this.dbContext.Hotels.ToListAsync();
    }

    public async Task<Hotel?> GetHotelAsync(int id)
    {
        return await this.dbContext.FindAsync<Hotel>(id);
    }

    public async Task<bool> AddHotelAsync(Hotel hotel)
    {
        await this.dbContext.AddAsync(hotel);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> RemoveHotelAsync(int id)
    {
        var hotel = this.dbContext.Find<Hotel>(id);
        if (hotel is null)
        {
            return false;
        }
        
        this.dbContext.Remove(hotel);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateHotelAsync(Hotel hotel)
    {
        this.dbContext.Update(hotel);
        return await this.dbContext.SaveChangesAsync() > 0;
    }
}