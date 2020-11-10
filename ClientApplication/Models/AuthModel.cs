using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class AuthModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "მომხმარებლის სახელი აუცილებელია")]
        [Display(Name = "მომხმარებლის სახელი")]
        public string Username { get; set; }

        [Required(ErrorMessage = "პაროლი აუცილებელია")]
        [StringLength(50, ErrorMessage = "სახელი არ უნდა იყოს 50 ასოზე მეტი")]
        [MinLength(8, ErrorMessage = "სახელი არ უნდა იყოს 2 სიმბოლოზე ნაკლები")]
        [Display(Name = "პაროლი")]
        public string Password { get; set; }
    }
}