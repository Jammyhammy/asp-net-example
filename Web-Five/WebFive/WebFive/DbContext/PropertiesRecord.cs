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
    
    public partial class PropertiesRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertiesRecord()
        {
            this.InvestmentsRecords = new HashSet<InvestmentsRecord>();
            this.LoanRecords = new HashSet<LoanRecord>();
            this.Tenants = new HashSet<Tenant>();
        }
    
        public long PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string Address { get; set; }
        public long CompanyId { get; set; }
        public byte[] PurchaseAgreement { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string PurchaseAgreementFileName { get; set; }
        public Nullable<decimal> PropertyAssessedValue { get; set; }
    
        public virtual CompanyRecord CompanyRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestmentsRecord> InvestmentsRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanRecord> LoanRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}
