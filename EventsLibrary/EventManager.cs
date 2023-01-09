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
    public Event AddNewMusicEvents(Event eventToAdd)
    {
        //Event createdEvent = new Event() { EventID = Guid.NewGuid(), Name = eventName, Type = "Music", State = stateName};
        if(String.IsNullOrEmpty(eventToAdd.Name))
        {
            throw new Exception("Se requiere un nombre");
        }
        eventToAdd.EventID = Guid.NewGuid();
        eventToAdd.Type="Music";
        eventToAdd.Date = new DateTime();
        musicEvent.Add(eventToAdd);
        return eventToAdd;
    }
    public Event AddNewSportEvents(Event eventToAdd)
    {
        //Event eventToAdd = new Event() { EventID = Guid.NewGuid(), Name = eventName, Type = "Sport", State = stateName};
        if(String.IsNullOrEmpty(eventToAdd.Name))
        {
            throw new Exception("Se requiere un nombre");
        }
        eventToAdd.EventID = Guid.NewGuid();
        sportEvent.Add(eventToAdd);
        eventToAdd.Type = "Sport";
        eventToAdd.Date = new DateTime();
        return eventToAdd;
    }
    public List<string> GetTypeOfEvents()
    {
        return events;
    }
    public List<Event> GetMusicEvents()
    {
        return musicEvent;
    }
    public Event UpdateMusicEvents(Guid id, Event eventToUpdate)
    {
        Event eventFound = musicEvent.Find(ev => ev.EventID == id);
        eventFound.Name = eventToUpdate.Name;
        eventFound.State = eventToUpdate.State;
        return eventToUpdate;
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
    public bool RemoveMusicEvents(Guid id)
    {
        Event eventFound = musicEvent.Find(ev => ev.EventID == id);
        if(eventFound != null)
                {
                     musicEvent.Remove(eventFound);
                     return true;
                }
        else
        {
            return false;
        }
    }
        public List<Event> GetSportEvents()
    {
        return sportEvent;
    }
    public Event UpdateSportEvents(Guid id, Event eventToUpdate)
    {
        Event eventFound = sportEvent.Find(ev => ev.EventID == id);
        eventFound.Name = eventToUpdate.Name;
        eventFound.State = eventToUpdate.State;
        return eventToUpdate;
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
    public bool RemoveSportEvents(Guid id)
    {
        Event eventFound = sportEvent.Find(ev => ev.EventID == id);
        if(eventFound != null)
                {
                     sportEvent.Remove(eventFound);
                     return true;
                }
        else
        {
            return false;
        }
    }
}