//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMCO.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Groups
    {
        public int GrpID_PK { get; set; }
        public Nullable<int> GroupType { get; set; }
        public string GrpName { get; set; }
        public string GrpDesc { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedUserID { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedUserID { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
    }
}
