﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Ecommerce.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EcommerceDbEntities : DbContext
    {
        public EcommerceDbEntities()
            : base("name=EcommerceDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<Gaming> Gamings { get; set; }
        public virtual DbSet<ThinLight> ThinLights { get; set; }
    }
}