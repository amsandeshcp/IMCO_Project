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
    
    public partial class tbl_Group_Login_X
    {
        public int GrpUserID_PK { get; set; }
        public int GrpID_FK { get; set; }
        public Nullable<int> Login_id_FK { get; set; }
        public Nullable<int> CreatedUserID { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedUserID { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
    }
}
