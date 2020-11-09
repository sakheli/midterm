using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class CountryModel
    {
        public int Id { get; set; }

        [Display(Name = "ქვეყანა")]
        public string Name { get; set; }
    }
}