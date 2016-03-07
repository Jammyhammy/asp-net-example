using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFive.Models.Reports
{
    public class IncomeTableReportModelView : BaseReportModelView
    {
        // Properties are pulled from the stored procedure.
        public long PropertyID { get; set; }
        
        public string PropertyAddress { get; set; }

        public string Name { get; set; }

        public int? Tenants { get; set; }
        public decimal? RentalIncome { get; set; }


    }
}
