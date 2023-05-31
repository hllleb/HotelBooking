using HotelBookingApp.Models;

namespace RoomBookingApp.Services;

public interface IRoomService
{
    Task<IEnumerable<Room>> GetAllRoomsAsync();

    Task<Room?> GetRoomAsync(int id);

    Task<bool> AddRoomAsync(Room room);

    Task<bool> RemoveRoomAsync(int id);

    Task<bool> UpdateRoomAsync(Room room);
}