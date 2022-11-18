namespace TicketDispenser
{
    public  class Event
    {
        //public string Type;
        public List<EventType> Type = new List<EventType>();
        public List<Zone> Zones = new List<Zone>();
        public string Name;
        public DateTime Date;
        public Locations Location;
        public void OrderInfo(User user, Tickets tickets) 
        {
        }
    }
    public class EventType
    {
        public string Name;
    }
    public class EventName
    {
        public string Name;
    }
}
