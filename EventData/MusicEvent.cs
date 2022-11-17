using TicketDispenser;

namespace TicketDispenser.EventData
{
    public class MusicEvent : Event
    {      
        public MusicEvent()
        {
                EventName = "Llajta Rock";
                EventDate = new DateTime(2022, 10, 28, 18, 0, 0);
                EventType = "Music";
                Location = new Locations
                {
                    LocationName = "Felix Capriles",
                    LocationCity = "Cercado",
                    LocationState = "Cochabamba",
                    LocationCountry = "Bolivia",
                    LocationCapacity = (32000 + 7000) - 5440
                };
                Zones = new List<Zone>
                {
                    new Zone ()
                    {
                        ZoneName = "Super VIP", 
                        ZoneCapacity = 1000, 
                        TicketPrice = 2500
                    },
                    new Zone ()
                    {
                        ZoneName = "VIP", 
                        ZoneCapacity = 2000, 
                        TicketPrice = 1100
                    },
                    new Zone ()
                    {
                        ZoneName = "Pista",
                        ZoneCapacity = 4000,
                        TicketPrice = 700
                    },
                    new Zone ()
                    {
                        ZoneName = "Preferencia",
                        ZoneCapacity = 10560,
                        TicketPrice = 400
                    },
                    new Zone ()
                    {
                        ZoneName = "General",
                        ZoneCapacity = 10560,
                        TicketPrice = 400
                    },
                    new Zone ()
                    {
                        ZoneName = "Curva Norte",
                        ZoneCapacity = 5440,
                        TicketPrice = 200
                    },
                };
        }
    }
}