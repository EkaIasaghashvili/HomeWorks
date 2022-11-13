using System.ComponentModel.DataAnnotations;
using System;

namespace HomeWork13.Validation
{
    public class ValidateDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object date, ValidationContext validationContext)
        {
            var time = Convert.ToDateTime(date).Hour;

            return time < 19 && time >= 10
                ? ValidationResult.Success
                : new ValidationResult("შეცდომა, არჩეული საათი არ ჯდება 10 - 19 დროის შუალედში");
        }
    }
}
