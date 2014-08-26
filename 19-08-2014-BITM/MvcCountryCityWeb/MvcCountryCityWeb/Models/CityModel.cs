using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCountryCityWeb.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        [DisplayName("City Name")]
        [Remote("IsNewCity", "City", ErrorMessage = "City Name is already axist!")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string About { get; set; }
        [DisplayName("No of Dweller")]
        public int NoOfDweller { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        [DisplayName("Country")]
        public virtual int CountryId { get; set; }
        public Country Country { get; set; }
    }
}