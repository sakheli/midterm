using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class ProductTypeModel
    {
        public int Id { get; set; }

        [Display(Name ="პროდუქტის ტიპი")]
        public string Name { get; set; }
    }
}