//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class HelpdeskRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HelpdeskRequest()
        {
            this.HelpdeskRequestLogs = new HashSet<HelpdeskRequestLog>();
            this.HelpdeskRequestHelpdeskSupporters = new HashSet<HelpdeskRequestHelpdeskSupporter>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> AssignDate { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> HelpdeskServiceId { get; set; }
        public Nullable<int> HouseId { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    
        public virtual HelpdeskService HelpdeskService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequestLog> HelpdeskRequestLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequestHelpdeskSupporter> HelpdeskRequestHelpdeskSupporters { get; set; }
        public virtual House House { get; set; }
    }
}
