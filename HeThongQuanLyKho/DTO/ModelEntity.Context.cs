﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyKhoEntities : DbContext
    {
        public QuanLyKhoEntities()
            : base("name=QuanLyKhoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DONVI> DONVIs { get; set; }
        public DbSet<HANGHOA> HANGHOAs { get; set; }
        public DbSet<HANGNHAP> HANGNHAPs { get; set; }
        public DbSet<HANGXUAT> HANGXUATs { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<NHOMHANG> NHOMHANGs { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }
    }
}
