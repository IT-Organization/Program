﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class huxiuEntities : DbContext
{
    public huxiuEntities()
        : base("name=huxiuEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<Activity> Activity { get; set; }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<DeleteLog> DeleteLog { get; set; }
    public DbSet<Headline> Headline { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Passage> Passage { get; set; }
    public DbSet<PassageCategory> PassageCategory { get; set; }
    public DbSet<PassageInformation> PassageInformation { get; set; }
}
