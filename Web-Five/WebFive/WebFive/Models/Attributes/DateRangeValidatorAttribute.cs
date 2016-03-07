using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFive.Models.Reports;

namespace WebFive.CustomAttributes
{
    /// <summary>
    /// this is customer server side date range validation attribute.
    /// </summary>
    public class DateRangeValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dateRange = (DateRangeModelView)value;

            if (DateTime.Compare(dateRange.FromDate, dateRange.ToDate) < 0 || DateTime.Compare(dateRange.ToDate, dateRange.FromDate) == 0)
                return new ValidationResult("Enter Valid Date range.");

            return base.IsValid(value, validationContext);
        }
    }
}
