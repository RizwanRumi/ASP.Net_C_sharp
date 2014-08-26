using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PartialViewPassingModel.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}