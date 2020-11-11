using ClientApplication.Models;
using ClientApplication.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientApplication.Controllers
{
    public class ProductController : Controller
    {
        ServiceReference.ClientServiceClient db = new ServiceReference.ClientServiceClient();

        // GET: Product
        public ActionResult Index()
        {
            List<ProductModel> model = new List<ProductModel>();

            var serviceModel = db.GetAllProducts();

            foreach (var item in serviceModel)
            {
                ProductModel obj = new ProductModel();
                obj.Id = item.Id;
                obj.Unique_Id = item.Unique_Id;
                obj.Name = item.Name;
                obj.Description = item.Description;
                obj.ProductType = item.ProductType.Name;
                obj.ISBN = item.ISBN;
                obj.Publish_Date = item.Publish_Date;
                obj.PublishingHouse = item.PublishingHouse.Name;
                obj.Pages = item.Pages;
                obj.Address = item.Address;
                model.Add(obj);

            }
            return View(model);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductModel model = new ProductModel { };

            var obj = db.GetProductByUnique_Id(id);

            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Id = obj.Id;
            model.Unique_Id = obj.Unique_Id;
            model.Name = obj.Name;
            model.Description = obj.Description;
            model.ProductType = obj.ProductType.Name;
            model.ISBN = obj.ISBN;
            model.Publish_Date = obj.Publish_Date;
            model.PublishingHouse = obj.PublishingHouse.Name;
            model.Pages = obj.Pages;
            model.Address = obj.Address;


            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new ProductModel { });
        }
         
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            //try
            //{
            //    // TODO: Add insert logic here
                if (!ModelState.IsValid)
                    throw new Exception("მოდელი არ არის ვალიდური");

                Random rd = new Random();
                int Unique_Id = rd.Next(100000, 999999);
                var objA = db.GetAuthorByUnique_Id(Unique_Id);
                if (objA == null)
                {
                    Unique_Id = rd.Next(100000, 999999);
                }

                string ISBN = new string(Enumerable.Repeat("0123456789", 13).Select(s => s[rd.Next(s.Length)]).ToArray());


                ProductDTO obj = new ProductDTO
                {
                    Unique_Id = Unique_Id,
                    Name = model.Name,
                    Description = model.Description,
                    ProductType = new ProductTypeDTO { Name = model.ProductType },
                    ISBN = ISBN,
                    Publish_Date = model.Publish_Date,
                    PublishingHouse = new Publishing_HouseDTO { Name = model.PublishingHouse },
                    Pages = model.Pages,
                    Address = model.Address
                };

                if (!db.AddNewProduct(obj, 1))
                {
                    return View(model);
                }

                return RedirectToAction("Index");

            //}
            //catch
            //{
            //    return View(model);
            //}
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel model = new ProductModel { };

            var obj = db.GetProductByUnique_Id(id);

            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Id = obj.Id;
            model.Unique_Id = obj.Unique_Id;
            model.Name = obj.Name;
            model.Description = obj.Description;
            model.ProductType = obj.ProductType.Name;
            model.ISBN = obj.ISBN;
            model.Publish_Date = obj.Publish_Date;
            model.PublishingHouse = obj.PublishingHouse.Name;
            model.Pages = obj.Pages;
            model.Address = obj.Address;


            return View(model);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductModel model)
        {
            try
            {
                // TODO: Add update logic here

                if (!ModelState.IsValid)
                    throw new Exception("მოდელი არ არის ვალიდური");

                ProductDTO objA = db.GetProductByUnique_Id(id);
                if (objA == null)
                {
                    TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                    return RedirectToAction("Index");
                }

                ProductDTO obj = new ProductDTO();

                obj.Name = model.Name;
                obj.Description = model.Description;
                obj.ProductType = new ProductTypeDTO { Name = model.ProductType };
                obj.ISBN = model.ISBN;
                obj.Publish_Date = model.Publish_Date;
                obj.PublishingHouse = new Publishing_HouseDTO { Name = model.PublishingHouse };
                obj.Pages = model.Pages;
                obj.Address = model.Address;

                db.UpdateProduct(obj);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductModel model = new ProductModel { };

            var obj = db.GetProductByUnique_Id(id);

            if (obj == null)
            {
                TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                return RedirectToAction("Index");
            }

            model.Id = obj.Id;
            model.Unique_Id = obj.Unique_Id;
            model.Name = obj.Name;
            model.Description = obj.Description;
            model.ProductType = obj.ProductType.Name;
            model.ISBN = obj.ISBN;
            model.Publish_Date = obj.Publish_Date;
            model.PublishingHouse = obj.PublishingHouse.Name;
            model.Pages = obj.Pages;
            model.Address = obj.Address;


            return View(model);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                ProductDTO obj = db.GetProductByUnique_Id(id);
                if (obj == null)
                {
                    TempData["Error"] = "ასეთი ჩანაწერი არ არსებობს";
                    return RedirectToAction("Index");
                }


                db.DeleteProduct(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
