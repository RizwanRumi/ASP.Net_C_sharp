using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCountryCityWeb.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required]
        [DisplayName("Country Name")]
        [Remote("IsNewCountry", "Country", ErrorMessage = "Country Name is already axist!")]
        public string Name { get; set; }

        public string About { get; set; }
    }
}