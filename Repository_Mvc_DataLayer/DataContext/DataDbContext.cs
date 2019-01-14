using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Repository_Mvc_DataLayer.DataEntity;

namespace Repository_Mvc_DataLayer.DataContext
{
    public class DataDbContext : DbContext
    {
        public DataDbContext():base("BDRepository")
        {
           

        }

        public DbSet<Product> Products { get; set; }
    }
}
