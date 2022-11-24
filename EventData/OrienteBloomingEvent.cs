namespace TicketDispenserExercise.EventData
{
    public class OrienteBloomingEvent : Event
    {
        public OrienteBloomingEvent()
        {
                Name = "Oriente Petrolero vs Blooming";
                Date = new DateTime(2022, 11, 26, 20, 0, 0);
                Type = TypeOfEvent.Sport;
                Location = new Locations
                {
                    Name = "Tahuichi Aguilera",
                    City = "Chiquitos",
                    State = "Santa Cruz de la sierra",
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