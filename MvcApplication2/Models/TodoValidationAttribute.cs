using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class TodoValidationAttribute : ValidationAttribute
    {
        public int MinimumValue { get; set; }

        public TodoValidationAttribute(int minimum)
        {
            MinimumValue = minimum;
        }

        public override bool IsValid(object value)
        {
            // Is value a string ?
            string valueToCompareSafe = "";
            if (value is string)
                valueToCompareSafe = value as string;
            else
                return false;

            // Has value more characters than mininmum ?
            if (valueToCompareSafe.Length > MinimumValue)
                return true;
            else
                return false;
        }
    }
}