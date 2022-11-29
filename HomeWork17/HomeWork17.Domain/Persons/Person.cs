using FluentValidation;
using HomeWork17.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HomeWork17.Domain.Persons
{
    public class Person : BaseEntity
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
        public List<Address> Address { get; set; }

        public void Update(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Salary = person.Salary;
            WorkExperince = person.WorkExperince;
            JobPosition = person.JobPosition;
            Address = person.Address;
        }
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.CreateDate)//თარიღის ვალიდაცია
                .NotEmpty()
                .LessThan(DateTime.Now).WithMessage("Date must be less then DateTime Now");

            RuleFor(x => x.FirstName)//სახელის ვალიდაცია
                .NotEmpty().WithMessage("Name is Empty, please enter the name")
                .Length(1, 50).WithMessage("Name length isn't correct");

            RuleFor(x => x.LastName)//გვარის ვალიდაცია
                .NotEmpty().WithMessage("Lastname is Empty, please enter the lastname")
                .Length(1, 50).WithMessage("Lastname length isn't correct");

            RuleFor(x => x.JobPosition)//პოზიციის ვალიდაცია
                .NotEmpty().WithMessage("Jobposition is Empty, please enter the jobposition")
                .Length(1, 50).WithMessage("Jobposition length isn't correct");

            RuleFor(x => x.Salary)//ანაზღაურება ვალიდაცია
                .InclusiveBetween(0, 10000).WithMessage("Salary must be between 0 to 10 000");

            RuleFor(x => x.WorkExperince)//გამოცდილება ვალიდაცია
                .NotEmpty().WithMessage("Workexperince is Empty, please enter the experince");
        }
    }
}
