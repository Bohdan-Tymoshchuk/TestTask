using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Abstractions;
using TestTask.Dtos;

namespace TestTask.Controllers
{
    [Route("api/incidents")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly IIncidentService _incidentService;

        public IncidentsController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }

        [HttpPost]
        public Task<int> Create(IncidentDto incident)
        {
            return _incidentService.Create(incident);
        }
    }
}
