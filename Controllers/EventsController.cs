using Microsoft.AspNetCore.Mvc;
using EventsLibrary.EventData;


namespace TicketDispenserExercise.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class EventsController : ControllerBase
    {
        private EventManager eventManager;
        public EventsController(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }
        [HttpGet]
        [Route("event-type")]
        public IActionResult GetTypeOfEvents()
        {
            return Ok(this.eventManager.GetTypeOfEvents());
        }

        [HttpGet]
        [Route("event-type-music")]
        public IActionResult GetMusicEvents()
        {
            return Ok(this.eventManager.GetMusicEvents());
        }
        [HttpGet]
        [Route("event-type-music-llajtaRock-zones")]
        public IActionResult GetLlajtaRockEventZones()
        {
            return Ok(this.eventManager.GetLlajtaRockEventZones());
         }   
        [HttpGet]
        [Route("event-type-music-download-zones")]
        public IActionResult GetDownloadEventZones()
        {
            return Ok(this.eventManager.GetDownloadEventZones());
        }
        [HttpGet]
        [Route("event-type-music-roadToUltra-zones")]
        public IActionResult GetRoadToUltraEventZones()
        {
            return Ok(this.eventManager.GetRoadToUltraEventZones());
        }
        [HttpGet]
        [Route("event-type-sport")]
        public IActionResult GetSportEvents()
        {
            return Ok(this.eventManager.GetSportEvents());
        }
        [HttpGet]
        [Route("event-type-sport-wilstermannAurora-zones")]
        public IActionResult GetWilsterAuroraEventZones()
        {
            return Ok(this.eventManager.GetWilsterAuroraEventZones());
        }
        [HttpGet]
        [Route("event-type-sport-bolivarStrongest-zones")]
        public IActionResult GetBolivarStrongestEventZones()
        {
            return Ok(this.eventManager.GetBolivarStrongestEventZones());
        }
        [HttpGet]
        [Route("event-type-sport-orienteBlooming-zones")]
        public IActionResult GetOrienteBloomingEventZones()
        {
            return Ok(this.eventManager.GetOrienteBloomingEventZones());
        }
    }
}