using FluentValidation;
using HomeWork17.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17.Domain.Persons
{
    public class Address : BaseEntity
    {
        public int PersonId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int HomeNumber { get; set; }
    }

    public  class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Country)//ქვეყნის ვალიდაცია
                .NotEmpty().WithMessage("Country is Empty, please enter the Country");
            RuleFor(x => x.City)//ქალაქის ვალიდაცია
                .NotEmpty().WithMessage("City is Empty, please enter the City");
            RuleFor(x => x.HomeNumber)//ტელეფონის ვალიდაცია
                .GreaterThan(0).WithMessage("Homenumber is Empty, please enter the phone number");
        }
    }
}
