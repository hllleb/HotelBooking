namespace HotelBookingApp.Models;

public class Reservation
{
    public int Id { get; set; }
    
    public int RoomId { get; set; }
    
    public int UserId { get; set; }
    
    public DateTime CheckInDate { get; set; }
    
    public DateTime CheckOutDate { get; set; }

    public Room Room { get; set; }
    
    public User User { get; set; }
}