using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Models
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
