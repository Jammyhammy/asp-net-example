using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebFive.Models.Data;

namespace WebFive.Controllers
{
    public class IncomeTableReportController : Controller
    {
        private PropertyManagementEntities db = new PropertyManagementEntities();

        public async Task<ActionResult> GetAllPropertyInfoForIncomeTable(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var propertyInfoForIncomeTable = db.GetAllPropertyInfoForIncomeTableForUser(id);

            if (propertyInfoForIncomeTable == null)
            {
                return HttpNotFound();
            }
            return View(propertyInfoForIncomeTable);
        }
    }
}
