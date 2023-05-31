using HotelBookingApp.Models;

namespace HotelBookingApp.Services;

public interface IReservationService
{
    Task<IEnumerable<Reservation>> GetAllReservationsAsync();

    Task<Reservation?> GetReservationAsync(int id);

    Task<bool> AddReservationAsync(Reservation hotel);

    Task<bool> RemoveReservationAsync(int id);

    Task<bool> UpdateReservationAsync(Reservation hotel);
}