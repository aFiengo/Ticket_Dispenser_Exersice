
namespace EventsLibrary.EventData
{
    public class RoadToUltraEvent : Event
    {      
        public RoadToUltraEvent()
        {
                Name = "Road to Ultra Music Festival";
                Date = new DateTime(2022, 12, 21, 18, 0, 0);
                Type = "Music";
                EventID = Guid.NewGuid();
                Location = new Locations
                {
                    Name = "Tahuichi Aguilera",
                    City = "Chiquitos",
                    State = "Santa Cruz de la sierra",
                    Country = "Bolivia",
                    Capacity = (32000 + 7000) - 5440
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        Name = "Super VIP", 
                        Capacity = 1000, 
                        TicketPrice = 1400
                    },
                    new Zone ()
                    {
                        Name = "VIP", 
                        Capacity = 2000, 
                        TicketPrice = 900
                    },
                    new Zone ()
                    {
                        Name = "Pista",
                        Capacity = 4000,
                        TicketPrice = 600
                    },
                    new Zone ()
                    {
                        Name = "Preferencia",
                        Capacity = 10560,
                        TicketPrice = 300
                    },
                    new Zone ()
                    {
                        Name = "General",
                        Capacity = 10560,
                        TicketPrice = 300
                    },
                    new Zone ()
                    {
                        Name = "Curva Norte",
                        Capacity = 5440,
                        TicketPrice = 200
                    },
                };
        }
    }
}