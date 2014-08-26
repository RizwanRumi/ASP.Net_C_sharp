﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryEntry2App.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string Country { get; set; }
    }
}