using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class Publishing_HouseModel
    {
        public int Id { get; set; }

        [Display(Name = "გამომცემლობის დასახელება")]
        public string Name { get; set; }
    }
}