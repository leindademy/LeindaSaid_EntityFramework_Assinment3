﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using LeindaSaid_EntityFramework_Assinment3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace LeindaSaid_EntityFramework_Assinment3.Entities.Configurations
{
    public partial class ProductsAboveAveragePriceConfiguration : IEntityTypeConfiguration<ProductsAboveAveragePrice>
    {
        public void Configure(EntityTypeBuilder<ProductsAboveAveragePrice> entity)
        {
            entity.ToView("Products Above Average Price");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductsAboveAveragePrice> entity);
    }
}