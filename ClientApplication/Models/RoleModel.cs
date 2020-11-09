using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class RoleModel
    {
        public int Id { get; set; }

        [Display(Name = "თანამდებობა")]
        public string Name { get; set; }

        [Display(Name = "აღწერა")]
        public string Description { get; set; }
    }
}