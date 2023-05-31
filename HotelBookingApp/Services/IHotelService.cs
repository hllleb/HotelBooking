using HotelBookingApp.Models;

namespace HotelBookingApp.Services;

public interface IHotelService
{
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();

    Task<Hotel?> GetHotelAsync(int id);

    Task<bool> AddHotelAsync(Hotel hotel);

    Task<bool> RemoveHotelAsync(int id);

    Task<bool> UpdateHotelAsync(Hotel hotel);
}