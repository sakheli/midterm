using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class CityModel
    {
        public int Id { get; set; }

        [Display(Name = "ქალაქი")]
        public string Name { get; set; }

        [Display(Name = "ქვეყანა")]
        public CountryModel Country { get; set; }
    }
}