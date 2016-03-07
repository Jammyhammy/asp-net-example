using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFive.CustomAttributes;
using WebFive.Models.Reports;

namespace WebFive.Models
{
    public abstract class BaseReportModelView
    {
        /// <summary>
        /// Gets and sets date radnge of report
        /// </summary>
        [DateRangeValidator]
        public DateRangeModelView DateRange { get; set; }
    }
}
