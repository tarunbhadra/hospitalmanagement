//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string EmailID { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsEmailVerified { get; set; }
        public Nullable<int> OrgID { get; set; }
        public Nullable<int> UserType { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    }
}