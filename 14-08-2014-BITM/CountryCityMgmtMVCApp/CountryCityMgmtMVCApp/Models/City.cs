using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityMgmtMVCApp.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int Id { get; set; }
        public virtual Country Country { get; set; }
    }
}