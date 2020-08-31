using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace Data.EFCore
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
