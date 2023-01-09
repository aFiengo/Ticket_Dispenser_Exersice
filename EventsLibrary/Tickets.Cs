namespace EventsLibrary
{
    public class Tickets
    {
        public string Zone { get; set; } 
        public Guid TID { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public Venues Location { get; set; }
    }
}