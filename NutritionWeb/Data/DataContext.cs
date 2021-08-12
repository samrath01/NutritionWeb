using Microsoft.EntityFrameworkCore;
using NutritionWeb.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Vitamin> Vitamins { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Supplement> Supplements { get; set; }

    }
}
