﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Update.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DATNEntities : DbContext
    {
        public DATNEntities()
            : base("name=DATNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CVE> CVEs { get; set; }
        public virtual DbSet<HEDIEUHANH> HEDIEUHANHs { get; set; }
        public virtual DbSet<MAYTINH> MAYTINHs { get; set; }
        public virtual DbSet<PHANMEM> PHANMEMs { get; set; }
        public virtual DbSet<PHIENBAN> PHIENBANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
