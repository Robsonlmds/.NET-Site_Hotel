namespace SiteHotel.Models
{
    public class DataClient
    {
        public int QtdAdults { get; set; }
        public int QtdChildren { get; set; }
        public required string SuiteName { get; set; } //required 
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required string Cusine { get; set; } //required 
    } 
}
