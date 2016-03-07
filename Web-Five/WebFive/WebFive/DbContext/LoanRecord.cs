//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFive.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoanRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanRecord()
        {
            this.PaymentRecords = new HashSet<PaymentRecord>();
        }
    
        public long LoanId { get; set; }
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public Nullable<decimal> LoanAmount { get; set; }
        public Nullable<System.DateTime> MaturityDate { get; set; }
        public Nullable<System.DateTime> LoanPaymentDueDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<long> PropertyId { get; set; }
    
        public virtual CompanyRecord CompanyRecord { get; set; }
        public virtual PropertiesRecord PropertiesRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentRecord> PaymentRecords { get; set; }
    }
}
