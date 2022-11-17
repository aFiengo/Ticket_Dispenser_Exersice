namespace TicketDispenser.EventData
{
    public class SportEvent : Event
    {
        public SportEvent()
        {
                EventName = "Wilstermann vs Aurora";
                EventDate = new DateTime(2022, 10, 26, 20, 0, 0);
                EventType = "Sport";
                Location = new Locations
                {
                    LocationName = "Felix Capriles",
                    LocationCity = "Cercado",
                    LocationState = "Cochabamba",
                    LocationCountry = "Bolivia",
                    LocationCapacity = 32000
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        ZoneName = "Butaca", 
                        ZoneCapacity = 4224, 
                        TicketPrice = 100
                    },
                    new Zone ()
                    {
                        ZoneName = "Preferencia", 
                        ZoneCapacity = 10560-4224, 
                        TicketPrice = 80
                    },
                    new Zone ()
                    {
                        ZoneName = "General", 
                        ZoneCapacity = 10560, 
                        TicketPrice = 60
                    },
                    new Zone ()
                    {
                        ZoneName = "Curva Norte", 
                        ZoneCapacity = 5440, 
                        TicketPrice = 40
                    },
                    new Zone ()
                    {
                        ZoneName = "Curva Sur", 
                        ZoneCapacity = 5440, 
                        TicketPrice = 40
                    },
                };
        }
    }
}