﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _19607040_ShopFashion.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopFasionEntities : DbContext
    {
        public ShopFasionEntities()
            : base("name=ShopFasionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<banner> banners { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<product> products { get; set; }
    }
}
