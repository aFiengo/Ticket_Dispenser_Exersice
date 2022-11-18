namespace TicketDispenser.EventData
{
    public class WilsterAuroraEvent : Event
    {
        public WilsterAuroraEvent()
        {
                Name = "Wilstermann vs Aurora";
                Date = new DateTime(2022, 10, 26, 20, 0, 0);
                Type = TypeOfEvent.Sport;
                Location = new Locations
                {
                    Name = "Felix Capriles",
                    City = "Cercado",
                    State = "Cochabamba",
                    Country = "Bolivia",
                    Capacity = 32000
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        Name = "Butaca", 
                        Capacity = 4224, 
                        TicketPrice = 100
                    },
                    new Zone ()
                    {
                        Name = "Preferencia", 
                        Capacity = 10560-4224, 
                        TicketPrice = 80
                    },
                    new Zone ()
                    {
                        Name = "General", 
                        Capacity = 10560, 
                        TicketPrice = 60
                    },
                    new Zone ()
                    {
                        Name = "Curva Norte", 
                        Capacity = 5440, 
                        TicketPrice = 40
                    },
                    new Zone ()
                    {
                        Name = "Curva Sur", 
                        Capacity = 5440, 
                        TicketPrice = 40
                    },
                };
        }
    }
}