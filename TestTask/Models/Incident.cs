namespace TestTask.Models
{
    public class Incident : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<Account> Accounts { get; set; }

    }
}
