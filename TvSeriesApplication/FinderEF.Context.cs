﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TvSeriesApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tvSeriesDBEntities : DbContext
    {
        public tvSeriesDBEntities()
            : base("name=tvSeriesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Series> tbl_Series { get; set; }
        public virtual DbSet<tbl_userlogin> tbl_userlogin { get; set; }
        public virtual DbSet<tv_UserSerie> tv_UserSerie { get; set; }
    }
}
