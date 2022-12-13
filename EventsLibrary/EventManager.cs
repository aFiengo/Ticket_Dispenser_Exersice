namespace EventsLibrary.EventData;

public class EventManager
{
    List<string> events;
    List<Event> musicEvent;
    List<Event> sportEvent;
    Event eventFound;
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
       for (int i=0; i<musicEvent.Count; i++)
        {
            if (musicEvent[i].EventID == EventID)
            {
                eventFound = musicEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Zone> GetSportEventZones(Guid EventID)
    {
        for (int i=0; i<sportEvent.Count; i++)
        {
            if (sportEvent[i].EventID == EventID)
            {
                eventFound = sportEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Event> GetSportEvents()
    {
        return sportEvent;
    }
}