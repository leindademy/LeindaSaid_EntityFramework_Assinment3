﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using LeindaSaid_EntityFramework_Assinment3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace LeindaSaid_EntityFramework_Assinment3.Entities.Configurations
{
    public partial class CategorySalesFor1997Configuration : IEntityTypeConfiguration<CategorySalesFor1997>
    {
        public void Configure(EntityTypeBuilder<CategorySalesFor1997> entity)
        {
            entity.ToView("Category Sales for 1997");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CategorySalesFor1997> entity);
    }
}