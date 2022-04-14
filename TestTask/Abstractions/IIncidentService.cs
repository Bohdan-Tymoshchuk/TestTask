using TestTask.Dtos;

namespace TestTask.Abstractions
{
    public interface IIncidentService
    {
        public Task<int> Create(IncidentDto incident);
    }
}
