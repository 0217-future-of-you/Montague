﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuoJinFirst.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_CateringEntities : DbContext
    {
        public DB_CateringEntities()
            : base("name=DB_CateringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Adddress_T> Adddress_T { get; set; }
        public DbSet<db_Shop_Type_T> db_Shop_Type_T { get; set; }
        public DbSet<db_Shopimage_T> db_Shopimage_T { get; set; }
        public DbSet<News_T> News_T { get; set; }
        public DbSet<News_Type_T> News_Type_T { get; set; }
        public DbSet<Order_T> Order_T { get; set; }
        public DbSet<Quanxian_T> Quanxian_T { get; set; }
        public DbSet<Shop_Information_T> Shop_Information_T { get; set; }
        public DbSet<Shop_T> Shop_T { get; set; }
        public DbSet<User_Information_T> User_Information_T { get; set; }
        public DbSet<User_Menu> User_Menu { get; set; }
        public DbSet<User_Type_T> User_Type_T { get; set; }
        public DbSet<User_Vip_T> User_Vip_T { get; set; }
        public DbSet<Menus_User_T> Menus_User_T { get; set; }
        public DbSet<Pinglun_T> Pinglun_T { get; set; }
        public DbSet<User_Menus_Quanxian_T> User_Menus_Quanxian_T { get; set; }
        public DbSet<Zhunjia_T> Zhunjia_T { get; set; }
    }
}