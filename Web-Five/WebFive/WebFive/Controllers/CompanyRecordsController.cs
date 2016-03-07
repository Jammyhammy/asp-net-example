using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFive.Models.Data;

namespace WebFive.Controllers
{
    public class CompanyRecordsController : Controller
    {
        private PropertyManagementEntities db = new PropertyManagementEntities();

        // GET: CompanyRecords
        public async Task<ActionResult> Index()
        {
            var companyRecords = db.CompanyRecords.Include(c => c.OwnerRecord);
            return View(await companyRecords.ToListAsync());
        }

        // GET: CompanyRecords/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRecord companyRecord = await db.CompanyRecords.FindAsync(id);
            if (companyRecord == null)
            {
                return HttpNotFound();
            }
            return View(companyRecord);
        }

        // GET: CompanyRecords/Create
        public ActionResult Create()
        {
            ViewBag.ManagingMember = new SelectList(db.OwnerRecords, "OwnerId", "OwnerName");
            return View();
        }

        // POST: CompanyRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CompanyId,Name,TaxId,ManagingMember,OperatingAgreement,ArticlesOfOrganization,DateOfIncorporation,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsActive,OperatingAgreementFileName,ArticlesOfOrganizationFileName")] CompanyRecord companyRecord)
        {
            if (ModelState.IsValid)
            {
                db.CompanyRecords.Add(companyRecord);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ManagingMember = new SelectList(db.OwnerRecords, "OwnerId", "OwnerName", companyRecord.ManagingMember);
            return View(companyRecord);
        }

        // GET: CompanyRecords/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRecord companyRecord = await db.CompanyRecords.FindAsync(id);
            if (companyRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.ManagingMember = new SelectList(db.OwnerRecords, "OwnerId", "OwnerName", companyRecord.ManagingMember);
            return View(companyRecord);
        }

        // POST: CompanyRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CompanyId,Name,TaxId,ManagingMember,OperatingAgreement,ArticlesOfOrganization,DateOfIncorporation,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsActive,OperatingAgreementFileName,ArticlesOfOrganizationFileName")] CompanyRecord companyRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyRecord).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ManagingMember = new SelectList(db.OwnerRecords, "OwnerId", "OwnerName", companyRecord.ManagingMember);
            return View(companyRecord);
        }

        // GET: CompanyRecords/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyRecord companyRecord = await db.CompanyRecords.FindAsync(id);
            if (companyRecord == null)
            {
                return HttpNotFound();
            }
            return View(companyRecord);
        }

        // POST: CompanyRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            CompanyRecord companyRecord = await db.CompanyRecords.FindAsync(id);
            db.CompanyRecords.Remove(companyRecord);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
