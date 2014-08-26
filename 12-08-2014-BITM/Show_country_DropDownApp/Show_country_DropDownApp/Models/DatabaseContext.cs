using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Show_country_DropDownApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Country> Acountry { get; set; }
        public DbSet<City> Acity { get; set; }
    }
}