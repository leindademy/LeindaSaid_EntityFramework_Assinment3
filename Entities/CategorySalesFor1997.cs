﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LeindaSaid_EntityFramework_Assinment3.Entities;

[Keyless]
public partial class CategorySalesFor1997
{
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? CategorySales { get; set; }
}