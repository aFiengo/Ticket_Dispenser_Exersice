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
    public List<Zone> GetLlajtaRockEventZones()
    {
        for (int i=0; i<musicEvent.Count; i++)
        {
            if (musicEvent[i].EventID == )
            {
                eventFound = musicEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Zone> GetDownloadEventZones()
    {
       for (int i=0; i<musicEvent.Count; i++)
        {
            if (musicEvent[i].Name == "Download Festival")
            {
                eventFound = musicEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Zone> GetRoadToUltraEventZones()
    {
        for (int i=0; i<musicEvent.Count; i++)
        {
            if (musicEvent[i].Name == "Road to Ultra Music Festival")
            {
                eventFound = musicEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Event> GetSportEvents()
    {
        return sportEvent;
    }
    public List<Zone> GetWilsterAuroraEventZones()
    {
       for (int i=0; i<sportEvent.Count; i++)
        {
            if (sportEvent[i].Name == "Wilstermann vs Aurora")
            {
                eventFound = sportEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Zone> GetBolivarStrongestEventZones()
    {
        for (int i=0; i<sportEvent.Count; i++)
        {
            if (sportEvent[i].Name == "Bolivar vs The Strongest")
            {
                eventFound = sportEvent[i];
            }
        }
        return eventFound.Zones;
    }
    public List<Zone> GetOrienteBloomingEventZones()
    {
        for (int i=0; i<sportEvent.Count; i++)
        {
            if (sportEvent[i].Name == "Oriente Petrolero vs Blooming")
            {
                eventFound = sportEvent[i];
            }
        }
        return eventFound.Zones;
    }
}