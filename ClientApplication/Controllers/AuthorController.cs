using ClientApplication.Models;
using ClientApplication.ServiceReference;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientApplication.Controllers
{
    public class AuthorController : Controller
    {
        ServiceReference.ClientServiceClient db = new ServiceReference.ClientServiceClient();
        // GET: Author
        public ActionResult Index(string sortOrder, string searchData)
        {

            ViewBag.IdSortParm = sortOrder == "id_desc" ? "id" : "id_desc";
            ViewBag.UniqIdSortParm = sortOrder == "uniqid_desc" ? "uniqid" : "uniqid_desc";
            ViewBag.NameSortParm = sortOrder == "name_desc" ? "name" : "name_desc";
            ViewBag.LastNameSortParm = sortOrder == "lastname_desc" ? "lastname" : "lastname_desc";
            ViewBag.GenderSortParm = sortOrder == "gender_desc" ? "gender" : "gender_desc";
            ViewBag.PerIdSortParm = sortOrder == "perid_desc" ? "perid" : "perid_desc";
            ViewBag.BirthDateSortParm = sortOrder == "birthdate_desc" ? "birthdate" : "birthdate_desc";
            ViewBag.CountSortParm = sortOrder == "count_desc" ? "count" : "count_desc";
            ViewBag.CitySortParm = sortOrder == "city_desc" ? "city" : "city_desc";
            ViewBag.PhoneSortParm = sortOrder == "phone_desc" ? "phone" : "phone_desc";
            ViewBag.EmailSortParm = sortOrder == "email_desc" ? "email" : "email_desc";


            List <AuthorModel> model = new List<AuthorModel>();



            var serviceModel = db.GetAllAuthores();
            List<AuthorDTO> authors;


            switch (sortOrder)
            {
                case "id_desc":
                    authors = serviceModel.OrderByDescending(s => s.Id).ToList();
                    break;
                case "id":
                    authors = serviceModel.OrderBy(s => s.Id).ToList();
                    break;
                case "uniqid_desc":
                    authors = serviceModel.OrderByDescending(s => s.Unique_Id).ToList();
                    break;
                case "uniqid":
                    authors = serviceModel.OrderBy(s => s.Unique_Id).ToList();
                    break;
                case "name_desc":
                    authors = serviceModel.OrderByDescending(s => s.Firstname).ToList();
                    break;
                case "name":
                    authors = serviceModel.OrderBy(s => s.Firstname).ToList();
                    break;
                case "lastname_desc":
                    authors = serviceModel.OrderByDescending(s => s.Lastname).ToList();
                    break;
                case "lastname":
                    authors = serviceModel.OrderBy(s => s.Lastname).ToList();
                    break;
                case "gender_desc":
                    authors = serviceModel.OrderByDescending(s => s.Gender.Gender1).ToList();
                    break;
                case "gender":
                    authors = serviceModel.OrderBy(s => s.Gender.Gender1).ToList();
                    break;
                case "perid_desc":
                    authors = serviceModel.OrderByDescending(s => s.Personal_Id).ToList();
                    break;
                case "perid":
                    authors = serviceModel.OrderBy(s => s.Personal_Id).ToList();
                    break;
                case "birthdate_desc":
                    authors = serviceModel.OrderByDescending(s => s.Birth_Date).ToList();
                    break;
                case "birthdate":
                    authors = serviceModel.OrderBy(s => s.Birth_Date).ToList();
                    break;
                case "count_desc":
                    authors = serviceModel.OrderByDescending(s => s.Country.Name).ToList();
                    break;
                case "count":
                    authors = serviceModel.OrderBy(s => s.Country.Name).ToList();
                    break;
                case "city_desc":
                    authors = serviceModel.OrderByDescending(s => s.City.Name).ToList();
                    break;
                case "city":
                    authors = serviceModel.OrderBy(s => s.City.Name).ToList();
                    break;
                case "phone_desc":
                    authors = serviceModel.OrderByDescending(s => s.Phone).ToList();
                    break;
                case "phone":
                    authors = serviceModel.OrderBy(s => s.Phone).ToList();
                    break;
                case "email_desc":
                    authors = serviceModel.OrderByDescending(s => s.Email).ToList();
                    break;
                case "email":
                    authors = serviceModel.OrderBy(s => s.Email).ToList();
                    break;
                default:
                    authors = serviceModel.ToList();
                    break;
            }


            if (!String.IsNullOrEmpty(searchData))
            {
                authors = authors.Where(s => s.Firstname.Contains(searchData) || s.Lastname.Contains(searchData)).ToList();
            }


            foreach (var item in authors)
            {
                AuthorModel obj = new AuthorModel();
                obj.Id = item.Id;
                obj.Unique_Id = item.Unique_Id;
                obj.Firstname = item.Firstname;
                obj.Lastname = item.Lastname;
                obj.Gender = item.Gender.Gender1;
                obj.Personal_Id = item.Personal_Id;
                obj.Birth_Date = item.Birth_Date;
                obj.Country = item.Country.Name;
                obj.City = item.City.Name;
                obj.Phone = item.Phone;
                obj.Email = item.Email;
                model.Add(obj);

            }

            return View(model);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            AuthorModel model = new AuthorModel { };

            var obj = db.GetAuthorByUnique_Id(id);

            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Id = obj.Id;
            model.Unique_Id = obj.Unique_Id;
            model.Firstname = obj.Firstname;
            model.Lastname = obj.Lastname;
            model.Gender = obj.Gender.Gender1;
            model.Personal_Id = obj.Personal_Id;
            model.Birth_Date = obj.Birth_Date;
            model.Country = obj.Country.Name;
            model.City = obj.City.Name;
            model.Phone = obj.Phone;
            model.Email = obj.Email;
            model.Products = db.GetProductsByAuthorId(obj.Id).Select(i =>
                new ProductModel
                {
                    Id = i.Id,
                    Unique_Id = i.Unique_Id,
                    Name = i.Name,
                    Description = i.Description,
                    ProductType = i.ProductType.Name,
                    ISBN = i.ISBN,
                    Publish_Date = i.Publish_Date,
                    PublishingHouse = i.PublishingHouse.Name,
                    Pages = i.Pages,
                    Address = i.Address
                }).ToList();


            return View(model);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View(new AuthorModel { });
        }

        // POST: Author/Create
        [HttpPost]
        public ActionResult Create(AuthorModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                    throw new Exception("მოდელი არ არის ვალიდური");

                Random rd = new Random();
                int Unique_Id = rd.Next(100000, 999999);
                var objA = db.GetAuthorByUnique_Id(Unique_Id);
                if (objA == null)
                {
                    Unique_Id = rd.Next(100000, 999999);
                }

                AuthorDTO obj = new AuthorDTO
                {
                    Unique_Id = Unique_Id,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Gender = new GenderDTO { Gender1 = model.Gender },
                    Personal_Id = model.Personal_Id,
                    Birth_Date = model.Birth_Date,
                    Country = new CountryDTO { Name = model.Country },
                    City = new CityDTO { Name = model.City },
                    Phone = model.Phone,
                    Email = model.Email,
                };

                if (!db.AddNewAuthor(obj))
                {
                    return View(model);
                }

                return RedirectToAction("Index");

            }
            catch
            {
                return View(model);
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            AuthorModel model = new AuthorModel { };

            AuthorDTO obj = db.GetAuthorByUnique_Id(id);
            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Unique_Id = obj.Unique_Id;
            model.Firstname = obj.Firstname;
            model.Lastname = obj.Lastname;
            model.Gender = obj.Gender.Gender1;
            model.Personal_Id = obj.Personal_Id;
            model.Birth_Date = obj.Birth_Date;
            model.Country = obj.Country.Name;
            model.City = obj.City.Name;
            model.Phone = obj.Phone;
            model.Email = obj.Email;

            return View(model);
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuthorModel model)
        {
            try
            {
                // TODO: Add update logic here

                if (!ModelState.IsValid)
                    throw new Exception("მოდელი არ არის ვალიდური");

                AuthorDTO objA = db.GetAuthorByUnique_Id(id);
                if (objA == null)
                {
                    TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                    return RedirectToAction("Index");
                }

                AuthorDTO obj = new AuthorDTO();

                obj.Unique_Id = model.Unique_Id;
                obj.Firstname = model.Firstname;
                obj.Lastname = model.Lastname;
                obj.Gender = new GenderDTO { Gender1 = model.Gender };
                obj.Personal_Id = model.Personal_Id;
                obj.Birth_Date = model.Birth_Date;
                obj.Country = new CountryDTO { Name = model.Country };
                obj.City = new CityDTO { Name = model.City };
                obj.Phone = model.Phone;
                obj.Email = model.Email;

                db.UpdateAuthor(obj);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            AuthorModel model = new AuthorModel { };

            AuthorDTO obj = db.GetAuthorByUnique_Id(id);
            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Unique_Id = obj.Unique_Id;
            model.Firstname = obj.Firstname;
            model.Lastname = obj.Lastname;
            model.Gender = obj.Gender.Gender1;
            model.Personal_Id = obj.Personal_Id;
            model.Birth_Date = obj.Birth_Date;
            model.Country = obj.Country.Name;
            model.City = obj.City.Name;
            model.Phone = obj.Phone;
            model.Email = obj.Email;

            return View(model);
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, AuthorModel model)
        {
            try
            {
                // TODO: Add delete logic here

                AuthorDTO objA = db.GetAuthorByUnique_Id(id);
                if (objA == null)
                {
                    TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                    return RedirectToAction("Index");
                }

                AuthorDTO obj = db.GetAuthorByUnique_Id(id);


                db.DeleteAuthor(obj);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Auth()
        {
            if (String.IsNullOrEmpty(HttpContext.Response.Cookies["Email"].Value) || String.IsNullOrEmpty(HttpContext.Response.Cookies["Password"].Value))
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Auth(StaffModel model)
        {
            if (String.IsNullOrEmpty(model.Email) || String.IsNullOrEmpty(model.AccountPassword)) {
                return View();
            }

            HttpContext.Response.Cookies.Add(new HttpCookie("Email", model.Email));
            HttpContext.Response.Cookies.Add(new HttpCookie("Password", model.AccountPassword));
            return RedirectToAction("Index");
        }
    }
}
