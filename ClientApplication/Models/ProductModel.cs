using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientApplication.Models
{
    public class ProductModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "უნიკალური Id")]
        public int? Unique_Id { get; set; }

        [Required(ErrorMessage = "აუცილებელია სახელი")]
        [StringLength(250, ErrorMessage = "სახელი არ უნდა იყოს 250 ასოზე მეტი")]
        [MinLength(2, ErrorMessage = "სახელი არ უნდა იყოს 2 სიმბოლოზე ნაკლები")]
        [Display(Name = "სახელი")]
        public string Name { get; set; }

        [Required(ErrorMessage = "აუცილებელია აღწერა")]
        [StringLength(50, ErrorMessage = "აღწერა არ უნდა იყოს 50 ასოზე მეტი")]
        [MinLength(2, ErrorMessage = "აღწერა არ უნდა იყოს 2 სიმბოლოზე ნაკლები")]
        [Display(Name = "აღწერა")]
        public string Description { get; set; }

        [Display(Name = "პროდუქტის ტიპი")]
        public string ProductType { get; set; }

        [Required(ErrorMessage = "ISBN")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "გამოქვეყნების წლის მითითება აუცილებელია")]
        [DataType(DataType.Date)]
        [Display(Name = "გამოქვეყნების წელი")]
        public DateTime Publish_Date { get; set; }

        [Display(Name = "გამომცემლობა")]
        public string PublishingHouse { get; set; }

        [Display(Name = "გვერდების რაოდენობა")]
        public int? Pages { get; set; }

        [Display(Name = "მისამართი")]
        public string Address { get; set; }

        public virtual List<AuthorModel> Authors { get; set; }
    }
}