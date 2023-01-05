using Microsoft.AspNetCore.Mvc;
using EventsLibrary.EventData;


namespace TicketDispenserExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private EventManager eventManager;
        public EventsController(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }
        [HttpGet]
        [Route("type")]
        public IActionResult GetTypeOfEvents()
        {
            return Ok(this.eventManager.GetTypeOfEvents());
        }
        [HttpPost]
        [Route("create/musicEvent")]
        public IActionResult CreateMusicEvents(string eventName)
        {
            this.eventManager.AddNewMusicEvents(eventName);
            return Ok(this.eventManager.GetMusicEvents());
        }
        [HttpPost]
        [Route("create/sportEvent")]
        public IActionResult CreateSportEvents(string eventName)
        {
            this.eventManager.AddNewSportEvents(eventName);
            return Ok(this.eventManager.GetSportEvents());
        }
        [HttpGet]
        [Route("type/music")]
        public IActionResult GetMusicEvents()
        {
            return Ok(this.eventManager.GetMusicEvents());
        }
        [HttpGet]
        [Route("type/sport")]
        public IActionResult GetSportEvents()
        {
            return Ok(this.eventManager.GetSportEvents());
        }
        [HttpGet]
        [Route("music/{EventID}")]
        public IActionResult GetMusicEventZones([FromRoute] Guid EventID)
        {
            return Ok(this.eventManager.GetMusicEventZones(EventID));
        }  
        [HttpPatch]
        [Route("music/edit/{EventID}")
        ] 
        [HttpGet]
        [Route("sport/{EventID}")]
        public IActionResult GetSportEventZones([FromRoute] Guid EventID)
        {
            return Ok(this.eventManager.GetSportEventZones(EventID));
        }
    }
}
//[FromRoute] Guid eventId