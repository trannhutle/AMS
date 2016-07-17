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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.BalanceSheets = new HashSet<BalanceSheet>();
            this.Comments = new HashSet<Comment>();
            this.HelpdeskRequests = new HashSet<HelpdeskRequest>();
            this.HelpdeskRequests1 = new HashSet<HelpdeskRequest>();
            this.HelpdeskRequestLogs = new HashSet<HelpdeskRequestLog>();
            this.HelpdeskRequestLogs1 = new HashSet<HelpdeskRequestLog>();
            this.NotificationChanges = new HashSet<NotificationChange>();
            this.NotificationObjects = new HashSet<NotificationObject>();
            this.Posts = new HashSet<Post>();
            this.Receipts = new HashSet<Receipt>();
            this.Reports = new HashSet<Report>();
            this.UserAnswerPolls = new HashSet<UserAnswerPoll>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> HouseId { get; set; }
        public Nullable<int> ResidentType { get; set; }
        public Nullable<int> Creator { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string IDNumber { get; set; }
        public Nullable<int> Gender { get; set; }
        public string Fullname { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> FamilyLevel { get; set; }
        public Nullable<System.DateTime> IDCreatedDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string SendPasswordTo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BalanceSheet> BalanceSheets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequest> HelpdeskRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequest> HelpdeskRequests1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequestLog> HelpdeskRequestLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HelpdeskRequestLog> HelpdeskRequestLogs1 { get; set; }
        public virtual House House { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationChange> NotificationChanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationObject> NotificationObjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAnswerPoll> UserAnswerPolls { get; set; }
    }
}
