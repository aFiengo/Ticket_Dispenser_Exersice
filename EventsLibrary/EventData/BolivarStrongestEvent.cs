
namespace EventsLibrary.EventData
{
    public class BolivarStrongestEvent : Event
    {      
        public BolivarStrongestEvent()
        {
                Name = "Bolivar vs The Strongest";
                Date = new DateTime(2022, 11, 28, 15, 0, 0);
                Type = "Sport";
                EventID = Guid.NewGuid();
                Location = new Locations
                {
                    Name = "Hernando Siles",
                    City = "Miraflores",
                    State = "La Paz",
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