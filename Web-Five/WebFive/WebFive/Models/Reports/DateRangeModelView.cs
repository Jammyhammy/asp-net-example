using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFive.Models.Reports
{
    public class DateRangeModelView
    {
        /// <summary>
        /// This property represents beginning date of report date range.
        /// </summary>
        [DisplayName("From:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FromDate { get; set; }


        /// <summary>
        /// This property represent ending date of report date range.
        /// </summary>
        [DisplayName("To:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// This Method gets number of months in a date range period
        /// </summary>
        /// <param name="dateRange"></param>
        /// <returns>number of months</returns>
        public int GetMonths(DateRangeModelView dateRange)
        {
            return dateRange.ToDate.Subtract(dateRange.FromDate).Days / 30;
        }

        public DateRangeModelView CurrentYearDateRange
        {
            get
            {
                return GetCurrentYearDateRange();
            }
        }

        public DateRangeModelView LastYearDateRange
        {
            get
            {
                return GetLastYearDateRange();
            }
        }

        /// <summary>
        /// This method returns current year's date range from january of current year until january following year.
        /// </summary>
        /// <returns>date range</returns>
        private DateRangeModelView GetCurrentYearDateRange()
        {
            DateRangeModelView currentYearDateRange = new DateRangeModelView();
            currentYearDateRange.FromDate = new DateTime(DateTime.Now.Year, 1, 1);
            currentYearDateRange.ToDate = currentYearDateRange.FromDate.AddYears(1);
            return currentYearDateRange;

        }

        private DateRangeModelView GetLastYearDateRange()
        {
            DateRangeModelView lastYearDateRange = new DateRangeModelView();
            lastYearDateRange.FromDate = CurrentYearDateRange.FromDate.AddYears(-1);
            lastYearDateRange.ToDate = CurrentYearDateRange.ToDate.AddYears(-1);
            return lastYearDateRange;

        }

    }
}
