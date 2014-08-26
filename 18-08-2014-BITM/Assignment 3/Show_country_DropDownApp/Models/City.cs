using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Show_country_DropDownApp.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string About { get; set; }
        public string NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryId { get; set; }
        public virtual Country  Countries { get; set; }
    }
}