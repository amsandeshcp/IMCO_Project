﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IMCODBEntities : DbContext
    {
        public IMCODBEntities()
            : base("name=IMCODBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Group_Login_X> tbl_Group_Login_X { get; set; }
        public virtual DbSet<tbl_Groups> tbl_Groups { get; set; }
        public virtual DbSet<tbl_Module> tbl_Module { get; set; }
        public virtual DbSet<tbl_Module_Functions> tbl_Module_Functions { get; set; }
        public virtual DbSet<tbl_Module_PermissionLevel> tbl_Module_PermissionLevel { get; set; }
        public virtual DbSet<tbl_People> tbl_People { get; set; }
        public virtual DbSet<tbl_People_Module_X> tbl_People_Module_X { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    }
}
