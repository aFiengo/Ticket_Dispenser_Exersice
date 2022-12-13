//using TicketDispenser;

namespace EventsLibrary.EventData
{
    public class LlajtaRockEvent : Event
    {      
        public LlajtaRockEvent()
        {
                Name = "Llajta Rock";
                Date = new DateTime(2022, 10, 28, 18, 0, 0);
                Type = "Music";
                EventID = Guid.NewGuid();
                Location = new Locations
                {
                    Name = "Felix Capriles",
                    City = "Cercado",
                    State = "Cochabamba",
                    Country = "Bolivia",
                    Capacity = (32000 + 7000) - 5440
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        Name = "Super VIP", 
                        Capacity = 1000, 
                        TicketPrice = 1500
                    },
                    new Zone ()
                    {
                        Name = "VIP", 
                        Capacity = 2000, 
                        TicketPrice = 800
                    },
                    new Zone ()
                    {
                        Name = "Pista",
                        Capacity = 4000,
                        TicketPrice = 500
                    },
                    new Zone ()
                    {
                        Name = "Preferencia",
                        Capacity = 10560,
                        TicketPrice = 250
                    },
                    new Zone ()
                    {
                        Name = "General",
                        Capacity = 10560,
                        TicketPrice = 250
                    },
                    new Zone ()
                    {
                        Name = "Curva Norte",
                        Capacity = 5440,
                        TicketPrice = 150
                    },
                };
        }
        public List<Zone> GetAllZones()
        {
            return Zones;
        }
    }
}