using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class UserModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "თანამდებობა")]
        public RoleModel Role { get; set; }

        [Display(Name = "ელექტონული ფოსტა")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "პაროლი")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}