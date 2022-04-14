namespace TestTask.Models
{
    public class Account : BaseEntity
    {
        public string? Name { get; set; }
        public int IncidentId { get; set; }
        public Incident Incident { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
