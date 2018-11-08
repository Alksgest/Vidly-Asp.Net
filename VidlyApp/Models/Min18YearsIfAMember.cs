using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = validationContext.ObjectInstance as Customer;
            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return age >= 18 ? 
                ValidationResult.Success :
                new ValidationResult("customer should be at least 19 years old to go on a membership");
            //return base.IsValid(value, validationContext);
        }
    }
}