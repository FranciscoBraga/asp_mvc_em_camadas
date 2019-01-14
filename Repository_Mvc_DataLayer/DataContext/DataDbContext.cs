using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Repository_Mvc_DataLayer.DataContext
{
    public class DataDbContext : DbContext
    {
        public DataDbContext():base("Name=BDRepository")
        {

        }
    }
}
