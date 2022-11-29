using System.ComponentModel.DataAnnotations;

namespace HomeWork17.Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
