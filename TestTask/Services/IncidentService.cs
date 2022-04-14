using TestTask.Abstractions;
using TestTask.Dtos;
using TestTask.Models;

namespace TestTask.Services
{
    public class IncidentService : IIncidentService
    {
        private readonly IIncidentRepository _incidentRepository;

        public IncidentService(IIncidentRepository incidentRepository)
        {
            _incidentRepository = incidentRepository;
        }

        public async Task<int> Create(IncidentDto incidentDto)
        {
            var incident = new Incident
            {
                Description = incidentDto.Description,
            };

            var createdAccount = await _incidentRepository.CreateAsync(incident);

            if (createdAccount == null)
            {
                throw new InvalidOperationException();
            }

            return incident.Id;
        }
    }
}
