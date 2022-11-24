namespace TicketDispenserExercise.EventData
{
    public class SportEvent 
    {
        public List<Event> Events { get; set;} = new List<Event>();
        public SportEvent()
        {
                Events.Add(new WilsterAuroraEvent());
                Events.Add(new BolivarStrongestEvent());
                Events.Add(new OrienteBloomingEvent());
        }
    }
}