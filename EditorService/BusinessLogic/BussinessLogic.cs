using EditorService.DataAccess;
using EditorService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditorService.BusinessLogic
{
    public class BussinessLogic
    {
        public static List<AuthorDTO> GetAllAuthores()
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    var result = db.Authors.Select(i =>
                    new AuthorDTO
                    {
                        Id = i.Id,
                        Unique_Id = i.Unique_Id,
                        Firstname = i.Firstname,
                        Lastname = i.Lastname,
                        Gender = new GenderDTO { Id = i.Gender.Id, Gender1 = i.Gender.Gender1 },
                        Personal_Id = i.Personal_Id,
                        Birth_Date = i.Birth_Date,
                        Country = new CountryDTO { Id = i.Gender.Id, Name = i.Country.Name },
                        City = new CityDTO { Id = i.Gender.Id, Name = i.City.Name, Id_Country = i.Id_Country },
                        Phone = i.Phone,
                        Email = i.Email
                    }).ToList();

                    return result;
                }
                catch (Exception ex)
                {
                    return new List<AuthorDTO>();
                }
            }
        }


        public static AuthorDTO GetAuthorByUnique_Id(int Unique_Id)
        {
            using (DBModel db = new DBModel())
            {
                if (!db.Authors.Any(i => i.Unique_Id == Unique_Id))
                    return null;

                var result = db.Authors.Where(i => i.Unique_Id ==Unique_Id)
                    .Select(i =>
                 new AuthorDTO
                 {
                     Id = i.Id,
                     Unique_Id = i.Unique_Id,
                     Firstname = i.Firstname,
                     Lastname = i.Lastname,
                     Gender = new GenderDTO { Id = i.Gender.Id, Gender1 = i.Gender.Gender1 },
                     Personal_Id = i.Personal_Id,
                     Birth_Date = i.Birth_Date,
                     Country = new CountryDTO { Id = i.Gender.Id, Name = i.Country.Name },
                     City = new CityDTO { Id = i.Gender.Id, Name = i.City.Name, Id_Country = i.Id_Country },
                     Phone = i.Phone,
                     Email = i.Email
                 }).First();

                return result;
            }
        }


        public static bool AddNewAuthor(AuthorDTO obj)
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    if (db.Authors.Any(i => i.Unique_Id == obj.Unique_Id))
                        throw new Exception("Already exists");

                    int Id_gender = db.Genders.Where(i => i.Gender1 == obj.Gender.Gender1).Select(i =>new GenderDTO{Id = i.Id}).First().Id;
                    int Id_Country = db.Countries.Where(i => i.Name == obj.Country.Name).Select(i => new CountryDTO { Id = i.Id }).First().Id;
                    int Id_City = db.Cities.Where(i => i.Name == obj.City.Name).Select(i => new CityDTO { Id = i.Id }).First().Id;

                    Author o = new Author()
                    {
                        Unique_Id = obj.Unique_Id,
                        Firstname = obj.Firstname,
                        Lastname = obj.Lastname,
                        Id_Gender = Id_gender,
                        Personal_Id = obj.Personal_Id,
                        Birth_Date = obj.Birth_Date,
                        Id_Country = Id_Country,
                        Id_City = Id_City,
                        Phone = obj.Phone,
                        Email = obj.Email
                    };

                    db.Authors.Add(o);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public static bool UpdateAuthor(AuthorDTO obj)
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    if (!db.Authors.Any(i => i.Unique_Id==obj.Unique_Id))
                        throw new Exception("Doesn't exists");

                    int Id_gender = db.Genders.Where(i => i.Gender1 == obj.Gender.Gender1).Select(i => new GenderDTO { Id = i.Id }).First().Id;
                    int Id_Country = db.Countries.Where(i => i.Name == obj.Country.Name).Select(i => new CountryDTO { Id = i.Id }).First().Id;
                    int Id_City = db.Cities.Where(i => i.Name == obj.City.Name).Select(i => new CityDTO { Id = i.Id }).First().Id;

                    Author modelData = db.Authors.Where(i => i.Unique_Id == obj.Unique_Id).First();

                    modelData.Firstname = obj.Firstname;
                    modelData.Lastname = obj.Lastname;
                    modelData.Id_Gender = Id_gender;
                    modelData.Personal_Id = obj.Personal_Id;
                    modelData.Birth_Date = obj.Birth_Date;
                    modelData.Id_Country = Id_Country;
                    modelData.Id_City = Id_City;
                    modelData.Phone = obj.Phone;
                    modelData.Email = obj.Email;

                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool DeleteAuthor(AuthorDTO obj)
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    if (!db.Authors.Any(i => i.Unique_Id == obj.Unique_Id))
                        throw new Exception("Doesn't exists");

                    Author modelData = db.Authors.Where(i => i.Unique_Id == obj.Unique_Id).First();
                    db.Authors.Remove(modelData);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public static List<ProductDTO> GetAllProducts()
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    var result = db.Products.Select(i =>
                    new ProductDTO
                    {
                        Id = i.Id,
                        Unique_Id = i.Unique_Id,
                        Name = i.Name,
                        Description = i.Description,
                        ProductType = new ProductTypeDTO { Id = i.ProductType.Id, Name = i.ProductType.Name },
                        ISBN = i.ISBN,
                        Publish_Date = i.Publish_Date,
                        PublishingHouse = new Publishing_HouseDTO { Id = i.Publishing_House.Id, Name = i.Publishing_House.Name },
                        Pages = i.Pages,
                        Address = i.Address
                    }).ToList();

                    return result;
                }
                catch (Exception ex)
                {
                    return new List<ProductDTO>();
                }
            }
        }


        public static ProductDTO GetProductByUnique_Id(int Unique_Id)
        {
            using (DBModel db = new DBModel())
            {
                if (!db.Products.Any(i => i.Unique_Id == Unique_Id))
                    return null;

                var result = db.Products.Where(i => i.Unique_Id == Unique_Id)
                    .Select(i =>
                 new ProductDTO
                 {
                     Id = i.Id,
                     Unique_Id = i.Unique_Id,
                     Name = i.Name,
                     Description = i.Description,
                     ProductType = new ProductTypeDTO { Id = i.ProductType.Id, Name = i.ProductType.Name },
                     ISBN = i.ISBN,
                     Publish_Date = i.Publish_Date,
                     PublishingHouse = new Publishing_HouseDTO { Id = i.Publishing_House.Id, Name = i.Publishing_House.Name },
                     Pages = i.Pages,
                     Address = i.Address
                 }).First();

                return result;
            }
        }

        public static List<ProductDTO> GetProductsByAuthorId(int AuthorId)
        {
            using (DBModel db = new DBModel())
            {
                if (!db.Authors.Any(i => i.Id == AuthorId))
                    return null;

                var result = db.Authors.Where(i => i.Id == AuthorId).First().Products.Select(i =>
                new ProductDTO
                {
                    Id = i.Id,
                    Unique_Id = i.Unique_Id,
                    Name = i.Name,
                    Description = i.Description,
                    ProductType = new ProductTypeDTO { Id = i.ProductType.Id, Name = i.ProductType.Name },
                    ISBN = i.ISBN,
                    Publish_Date = i.Publish_Date,
                    PublishingHouse = new Publishing_HouseDTO { Id = i.Publishing_House.Id, Name = i.Publishing_House.Name },
                    Pages = i.Pages,
                    Address = i.Address
                }).ToList();

                return result;
            }
        }


        public static bool AddNewProduct(ProductDTO obj, int unique_id)
        {
            using (DBModel db = new DBModel())
            {
                //try
                //{
                    if (db.Products.Any(i => i.Unique_Id == obj.Unique_Id))
                        throw new Exception("Already exists");

                    int Id_productType = db.ProductTypes.Where(i => i.Name == obj.ProductType.Name).Select(i => new ProductTypeDTO { Id = i.Id }).First().Id;
                    int Id_publishingHouse = db.Publishing_House.Where(i => i.Name == obj.PublishingHouse.Name).Select(i => new Publishing_HouseDTO { Id = i.Id }).First().Id;

                    Product o = new Product()
                    {
                        Unique_Id = obj.Unique_Id,
                        Name = obj.Name,
                        Description = obj.Description,
                        Id_ProductType = Id_productType,
                        ISBN = obj.ISBN,
                        Publish_Date = obj.Publish_Date,
                        Id_PublishingHouse = Id_publishingHouse,
                        Pages = obj.Pages,
                        Address = obj.Address
                    };

                    Author author = db.Authors.Where(i => i.Unique_Id == unique_id).FirstOrDefault();
                    o.Authors.Add(author);
                    db.Products.Add(o);
                    db.SaveChanges();

                    return true;
                //}
                //catch (Exception ex)
                //{
                //    return false;
                //}
            }
        }


        public static bool UpdateProduct(ProductDTO obj)
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    if (!db.Products.Any(i => i.Unique_Id == obj.Unique_Id))
                        throw new Exception("Doesn't exists");

                    int Id_productType = db.ProductTypes.Where(i => i.Name == obj.ProductType.Name).Select(i => new ProductTypeDTO { Id = i.Id }).First().Id;
                    int Id_publishingHouse = db.Publishing_House.Where(i => i.Name == obj.PublishingHouse.Name).Select(i => new Publishing_HouseDTO { Id = i.Id }).First().Id;

                    Product modelData = db.Products.Where(i => i.Unique_Id == obj.Unique_Id).First();
                    modelData.Unique_Id = obj.Unique_Id;
                    modelData.Name = obj.Name;
                    modelData.Description = obj.Description;
                    modelData.Id_ProductType = Id_productType;
                    modelData.ISBN = obj.ISBN;
                    modelData.Publish_Date = obj.Publish_Date;
                    modelData.Id_PublishingHouse = Id_publishingHouse;
                    modelData.Pages = obj.Pages;
                    modelData.Address = obj.Address;

                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool DeleteProduct(ProductDTO obj)
        {
            using (DBModel db = new DBModel())
            {
                try
                {
                    if (!db.Products.Any(i => i.Unique_Id == obj.Id))
                        throw new Exception("Doesn't exists");

                    Product modelData = db.Products.Where(i => i.Unique_Id == obj.Unique_Id).First();
                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public static UserDTO Authorize(string Email, string Password) {
            using (DBModel db = new DBModel())
            {
                try
                {
                    var result = db.Staffs.Select(i =>
                    new UserDTO
                    {
                        Id = i.Id,
                        Role = new RoleDTO { Id = i.Role.Id, Name = i.Role.Name, Description = i.Role.Description },
                        Email = i.Email, 
                        Password = i.Password
                    }).Where(modelData => modelData.Email == Email && modelData.Password == Password).First();

                    return result;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}