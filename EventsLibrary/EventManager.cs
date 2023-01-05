namespace EventsLibrary.EventData;

public class EventManager : Event
{
    List<string> events;
    List<Event> musicEvent;
    List<Event> sportEvent;
    public EventManager()
    {
        musicEvent = new List<Event>();
        sportEvent = new List<Event>();
        events = new List<string>();
        events.Add("Music");
        events.Add("Sport");
        musicEvent.Add(new DownloadEvent());
        musicEvent.Add(new LlajtaRockEvent());
        musicEvent.Add(new RoadToUltraEvent());
        sportEvent.Add(new WilsterAuroraEvent());
        sportEvent.Add(new BolivarStrongestEvent());
        sportEvent.Add(new OrienteBloomingEvent());
        
    }
    public Event AddNewMusicEvents(string eventName)
    {
        Event createdEvent = new Event() { EventID = Guid.NewGuid(), Name = eventName};
        musicEvent.Add(createdEvent);
        return createdEvent;
    }
    public Event AddNewSportEvents(string eventName)
    {
        Event createdEvent = new Event() { EventID = Guid.NewGuid(), Name = eventName};
        sportEvent.Add(createdEvent);
        return createdEvent;
    }
    public List<string> GetTypeOfEvents()
    {
        return events;
    }
    public List<Event> GetMusicEvents()
    {
        return musicEvent;
    }
    public List<Zone> GetMusicEventZones(Guid EventID)
    {
       Event eventFound = null;
        for (int i=0; i<musicEvent.Count; i++)
        {
            if (musicEvent[i].EventID == EventID)
            {
                eventFound = musicEvent[i];
            }
        }
        return eventFound != null ?  eventFound.Zones : new List<Zone>();
    }
    public List<Zone> GetSportEventZones(Guid EventID)
    {
        Event eventFound = null;
        for (int i=0; i<sportEvent.Count; i++)
        {
            if (sportEvent[i].EventID == EventID)
            {
                eventFound = sportEvent[i];
            }
        }
        return eventFound != null ?  eventFound.Zones : new List<Zone>();
    }
    public List<Event> GetSportEvents()
    {
        return sportEvent;
    }
}