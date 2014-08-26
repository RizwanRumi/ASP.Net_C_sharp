using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapPracticeApp.Models
{
    public class Map
    {
        public string Location { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
} 