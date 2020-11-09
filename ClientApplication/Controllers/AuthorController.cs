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
        public ActionResult Index()
        {
            List<AuthorModel> model = new List<AuthorModel>();

            var serviceModel = db.GetAllAuthores();

            foreach (var item in serviceModel)
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
    }
}
