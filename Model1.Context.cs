﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulSistemi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OkulSistemiEntities : DbContext
    {
        public OkulSistemiEntities()
            : base("name=OkulSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAlinanDersler> tblAlinanDersler { get; set; }
        public virtual DbSet<tblDers> tblDers { get; set; }
        public virtual DbSet<tblNotlar> tblNotlar { get; set; }
        public virtual DbSet<tblOgrenci> tblOgrenci { get; set; }
        public virtual DbSet<tblOgretmen> tblOgretmen { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblVerilenDersler> tblVerilenDersler { get; set; }
    }
}