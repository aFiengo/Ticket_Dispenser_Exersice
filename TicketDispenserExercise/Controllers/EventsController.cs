using Microsoft.AspNetCore.Mvc;
using EventsLibrary.EventData;
using EventsLibrary;

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
        public IActionResult CreateMusicEvents(Event eventToAdd)
        {
            this.eventManager.AddNewMusicEvents(eventToAdd);
            return Ok(eventToAdd);
        }
        [HttpPost]
        [Route("create/sportEvent")]
        public IActionResult CreateSportEvents(Event eventName)
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
        [HttpPut]
        [Route("music/edit/{EventID}")]
        public IActionResult UpdateMusicEvents([FromRoute] Guid EventID, [FromBody] Event eventToUpdate) 
        {
            return Ok(this.eventManager.UpdateMusicEvents(EventID, eventToUpdate));
        }
        [HttpDelete]
        [Route("music/remove/{EventID}")]
        public IActionResult DeleteMusicEvents([FromRoute] Guid EventID) 
        {
            this.eventManager.RemoveMusicEvents(EventID);
            return Ok(this.eventManager.GetMusicEvents());
        }
        [HttpGet]
        [Route("sport/{EventID}")]
        public IActionResult GetSportEventZones([FromRoute] Guid EventID)
        {
            return Ok(this.eventManager.GetSportEventZones(EventID));
        }
        [HttpPut]
        [Route("sport/edit/{EventID}")]
        public IActionResult UpdateSportEvents([FromRoute] Guid EventID, [FromBody] Event eventToUpdate) 
        {
            return Ok(this.eventManager.UpdateSportEvents(EventID, eventToUpdate));
        }
        [HttpDelete]
        [Route("sport/remove/{EventID}")]
        public IActionResult DeleteSportEvents([FromRoute] Guid EventID) 
        {
            this.eventManager.RemoveSportEvents(EventID);
            return Ok(this.eventManager.GetSportEvents());
        }
    }
}
//[FromRoute] Guid eventId