using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class GenderModel
    {
        public int Id { get; set; }

        [Display(Name = "სქესი")]
        public string Gender1 { get; set; }
    }
}