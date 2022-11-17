namespace TicketDispenser
{
    public  class Event
    {
        public string EventType;
        public List<Zone> Zones = new List<Zone>();
        public string EventName;
        public DateTime EventDate;
        public Locations Location;
        public void OrderInfo(User user, Tickets tickets) 
        {
        }
    }
}
