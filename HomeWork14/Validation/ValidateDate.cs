using FluentValidation;
using HomeWork14.Models;
using System;

namespace HomeWork14.Validation
{
    public class ValidateDate : AbstractValidator<PersonData>
    {
        public ValidateDate()
        {
            RuleFor(x => x.CreateDate)//თარიღის ვალიდაცია
                .NotEmpty()
                .GreaterThan(DateTime.Now).WithMessage("Date must be DateTime Now");

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

            RuleFor(x => x.Adress)//მისამართი ვალიდაცია
                .NotEmpty().WithMessage("Adress is Empty, please enter the adress");
        }
    }
}
