using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Model
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=94.73.150.5;Database=u7402684_akboru;Trusted_Connection=False;User ID=u7402684_akboru;Password=AKboru_2021_erp");
        }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
    }
}
