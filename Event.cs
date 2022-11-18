namespace TicketDispenser
{
    public  class Event
    {
        //public string Type;
        public TypeOfEvent Type { get; set; }
        public List<Zone> Zones = new List<Zone>();
        public string Name { get; set; }
        public DateTime Date;
        public Locations Location;
    }
}
