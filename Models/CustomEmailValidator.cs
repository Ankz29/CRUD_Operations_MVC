using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CRUD_Operations_Using_EF.Models
{
    public class CustomEmailValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string Email = value.ToString();
                if (Regex.IsMatch(Email, @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Kindly enter valid email id ed. abc@gmail.com ");
                }
            }
            else
            {
                return new ValidationResult("Email id is required, kindly enter !!");
            }            
        }      
    }

    public class CustomPhoneNumberValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            if (value != null)
            {
                string PhoneNumber = value.ToString();
                if (Regex.IsMatch(PhoneNumber, @"^\d{10}$", RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Kindly enter 10 digit Phone number !!!!!");
                }
            }
            else
            {
                return new ValidationResult("Phone Number is required !!");
            }

        }
    }
}