using TestTask.Abstractions;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class IncidentRepository : BaseRepository<Incident>, IIncidentRepository
    {
        private readonly DataContext _context;
        public IncidentRepository(DataContext context) : base(context)
        {
            _context = context;
        }


    }
}
