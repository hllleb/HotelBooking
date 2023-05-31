using HotelBookingApp.Data;
using HotelBookingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.Services;

public class RoomService
{
    private readonly HotelBookingDbContext dbContext;

    public RoomService(HotelBookingDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        return await this.dbContext.Rooms.ToListAsync();
    }

    public async Task<Room?> GetRoomAsync(int id)
    {
        return await this.dbContext.FindAsync<Room>(id);
    }

    public async Task<bool> AddRoomAsync(Room room)
    {
        await this.dbContext.AddAsync(room);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> RemoveRoomAsync(int id)
    {
        var room = this.dbContext.Find<Room>(id);
        if (room is null)
        {
            return false;
        }
        
        this.dbContext.Remove(room);
        return await this.dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateRoomAsync(Room room)
    {
        this.dbContext.Update(room);
        return await this.dbContext.SaveChangesAsync() > 0;
    }
}