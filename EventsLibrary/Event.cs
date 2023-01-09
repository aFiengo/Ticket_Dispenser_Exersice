namespace EventsLibrary;
public  class Event
    {
        public string Type { get; set; }
        public List<Zone> Zones = new List<Zone>();
        public string Name { get; set; }
        public DateTime Date;
        public Venues Location;
        public Guid EventID { get; set; }
        public string State { get; set; }
    }