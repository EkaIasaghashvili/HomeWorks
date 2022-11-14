using System;
using System.ComponentModel.DataAnnotations;

namespace HomeWork14.Models
{
    public class PersonData
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string JobPosition { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public double WorkExperince { get; set; }
        [Required]
        public Adress Adress { get; set; }
    }
}
