using HomeWork13.Validation;
using Microsoft.VisualBasic;
using System;

namespace HomeWork13.Models
{
    public class Reserve
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Doctor { get; set; }
        [ValidateDate]
        public DateTime Time { get; set; }
    }
}
