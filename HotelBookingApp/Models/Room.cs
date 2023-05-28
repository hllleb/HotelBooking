namespace HotelBookingApp.Models;

public class Room
{
    public int Id { get; set; }
    
    public int HotelId { get; set; }
    
    public string Number { get; set; }
    
    public string Type { get; set; }
    
    public decimal Price { get; set; }
    
    public bool IsAvailable { get; set; }
    
    public Hotel Hotel { get; set; }
    
    public List<Reservation> Reservations { get; set; }
}