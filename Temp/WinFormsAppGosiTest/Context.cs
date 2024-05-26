using System;
using Microsoft.EntityFrameworkCore;

namespace WinFormsAppGosiTest
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Initial Catalog=Context");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarPark> CarParks { get; set; }

    }
}
