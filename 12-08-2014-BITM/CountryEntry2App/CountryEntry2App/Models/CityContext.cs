using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CountryEntry2App.Models
{
    public class CityContext : DbContext
    {
        public DbSet<City> ACities { get; set; }
    }
}