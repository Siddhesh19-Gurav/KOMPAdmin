﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KOMP.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBKOMPEntities : DbContext
    {
        public DBKOMPEntities()
            : base("name=DBKOMPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Config> Configs { get; set; }
        public DbSet<HoliDay> HoliDays { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<ShippingBilling> ShippingBillings { get; set; }
        public DbSet<tblLocation> tblLocations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeeklyMenu> WeeklyMenus { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}