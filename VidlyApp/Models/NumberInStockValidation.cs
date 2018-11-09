using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class NumberInStockValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = validationContext.ObjectInstance as Movie;

            return movie.NumberInStock >= 1 && movie.NumberInStock <= 20 ?
                ValidationResult.Success :
                new ValidationResult("The field Number In Stock must be between 1 and 20");
        }
    }
}