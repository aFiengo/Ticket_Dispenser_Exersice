using Microsoft.AspNetCore.Mvc;

namespace TicketDispenserExercise.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class EventsController : ControllerBase
    {
        public EventsController()
        {}
        [HttpGet]
        [Route("get-all-types-of-events")]
        public IActionResult GetTypeOfEvents()
        {
            List<Event> events = new List<Event>();
            events.Add(new Event(){ Name = "Music Event"} );
             events.Add(new Event(){ Name = "Sport Event"} );
                return Ok(events);
        }

        [HttpGet]
        [Route("get-all-music-events")]
        public IActionResult GetMusicEvents()
        {
            List<string> musicEvents = new List<string>();
            musicEvents.Add("Llajta Rock");
            musicEvents.Add("Download Festival");
            musicEvents.Add("Road To Ultra Music Fest");
            return Ok(musicEvents);
        }
        [HttpGet]
        [Route("llajta-rock-event")]
        public IActionResult GetLlajtaRockEvent()
        {
            List<string> llajtaRockZones = new List<string>();
            llajtaRockZones.Add("Super VIP");
            llajtaRockZones.Add("VIP");
            llajtaRockZones.Add("Pista");
            llajtaRockZones.Add("Preferencia");
            llajtaRockZones.Add("General");
            llajtaRockZones.Add("Curva");
            return Ok(llajtaRockZones);
        }
    }
}