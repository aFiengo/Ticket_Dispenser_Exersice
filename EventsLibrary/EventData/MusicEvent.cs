
namespace EventsLibrary.EventData
{
    public class MusicEvent 
    {      
        public List<Event> Events { get; set;} = new List<Event>();
        public MusicEvent()
        {
                Events.Add(new LlajtaRockEvent());
                Events.Add(new DownloadEvent());
                Events.Add(new RoadToUltraEvent());
        }
    }
}