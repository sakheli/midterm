﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class StaffModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "აუცილებელია სახელი")]
        [StringLength(50, ErrorMessage = "სახელი არ უნდა იყოს 50 ასოზე მეტი")]
        [MinLength(2, ErrorMessage = "სახელი არ უნდა იყოს 2 სიმბოლოზე ნაკლები")]
        [Display(Name = "სახელი")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "გვარი")]
        [StringLength(50, ErrorMessage = "სახელი არ უნდა იყოს 50 ასოზე მეტი")]
        [MinLength(2, ErrorMessage = "სახელი არ უნდა იყოს 2 სიმბოლოზე ნაკლები")]
        [Display(Name = "გვარი")]
        public string Lastname { get; set; }

        [Display(Name = "სქესი")]
        public int? Id_Gender { get; set; }

        [Display(Name = "თანამდებობა")]
        public RoleModel Role { get; set; }

        [Required(ErrorMessage = "პირადი ნომერის მითითება აუცილებელია")]
        [StringLength(11, ErrorMessage = "პირადი ნომერი არ უნდა იყოს 11 ციფრზე მეტი")]
        [Display(Name = "პირადი ნომერი")]
        public string Personal_Id { get; set; }

        [Required(ErrorMessage = "დაბადების წლის მითითება აუცილებელია")]
        //[Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "დაბადების წელი")]
        public DateTime Birth_Date { get; set; }

        [Display(Name = "ქვეყანა")]
        public int? Id_Country { get; set; }

        [Display(Name = "ქალაქი")]
        public int? Id_City { get; set; }

        [StringLength(50, ErrorMessage = "ტელეფონი არ უნდა იყოს 50 ასოზე მეტი")]
        [MinLength(4, ErrorMessage = "ტელეფონი არ უნდა იყოს 4 სიმბოლოზე ნაკლები")]
        [Display(Name = "ტელეფონი")]
        public string Phone { get; set; }

        [Display(Name = "ელექტონული ფოსტა")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "პაროლი")]
        [DataType(DataType.Password)]
        public string AccountPassword { get; set; }
    }
}