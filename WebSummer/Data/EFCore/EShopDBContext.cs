using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Data.Entities;
namespace Data.EFCore
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; };
    }
}
