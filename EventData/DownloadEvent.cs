using TicketDispenser;

namespace TicketDispenser.EventData
{
    public class DownloadEvent : Event
    {      
        public DownloadEvent()
        {
                Name = "Download Music Fest";
                Date = new DateTime(2022, 11, 28, 15, 0, 0);
                Type = new List<EventType> 
                {
                    new EventType()
                    {
                        Name = "Music Event"
                    }
                };
                Location = new Locations
                {
                    Name = "Hernando Siles",
                    City = "Miraflores",
                    State = "La Paz",
                    Country = "Bolivia",
                    Capacity = (32000 + 7000) - 5440
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        Name = "Super VIP", 
                        Capacity = 1000, 
                        TicketPrice = 2500
                    },
                    new Zone ()
                    {
                        Name = "VIP", 
                        Capacity = 2000, 
                        TicketPrice = 1200
                    },
                    new Zone ()
                    {
                        Name = "Pista",
                        Capacity = 4000,
                        TicketPrice = 800
                    },
                    new Zone ()
                    {
                        Name = "Preferencia",
                        Capacity = 10560,
                        TicketPrice = 500
                    },
                    new Zone ()
                    {
                        Name = "General",
                        Capacity = 10560,
                        TicketPrice = 500
                    },
                    new Zone ()
                    {
                        Name = "Curva Norte",
                        Capacity = 5440,
                        TicketPrice = 250
                    },
                };
        }
    }
}