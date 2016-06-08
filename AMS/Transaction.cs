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
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<double> PaidAmount { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual BalanceSheet BalanceSheet { get; set; }
        public virtual TransactionCategory TransactionCategory { get; set; }
    }
}
