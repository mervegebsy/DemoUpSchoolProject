﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoUpSchoolProject.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UpSchoolDbPortfolioEntities : DbContext
    {
        public UpSchoolDbPortfolioEntities()
            : base("name=UpSchoolDbPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblServices> TblServices { get; set; }
        public virtual DbSet<TblServicesFeature> TblServicesFeature { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
    }
}
