//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFive.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OwnerCompanyLink
    {
        public long OwnerID { get; set; }
        public long CompanyId { get; set; }
        public Nullable<decimal> OwnershipPercentage { get; set; }
    
        public virtual CompanyRecord CompanyRecord { get; set; }
        public virtual OwnerRecord OwnerRecord { get; set; }
    }
}
