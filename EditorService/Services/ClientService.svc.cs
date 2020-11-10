using EditorService.DataContracts;
using EditorService.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EditorService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClientService.svc or ClientService.svc.cs at the Solution Explorer and start debugging.
    public class ClientService : IClientService
    {
        public List<AuthorDTO> GetAllAuthores()
        {
            return BusinessLogic.BussinessLogic.GetAllAuthores();
        }

        public AuthorDTO GetAuthorByUnique_Id(int Unique_Id)
        {
            return BusinessLogic.BussinessLogic.GetAuthorByUnique_Id(Unique_Id);
        }

        public bool AddNewAuthor(AuthorDTO obj)
        {
            return BusinessLogic.BussinessLogic.AddNewAuthor(obj);
        }

        public bool UpdateAuthor(AuthorDTO obj)
        {
            return BusinessLogic.BussinessLogic.UpdateAuthor(obj);
        }

        public bool DeleteAuthor(AuthorDTO obj)
        {
            return BusinessLogic.BussinessLogic.DeleteAuthor(obj);
        }

        public List<ProductDTO> GetAllProducts()
        {
            return BusinessLogic.BussinessLogic.GetAllProducts();
        }

        public ProductDTO GetProductByUnique_Id(int Unique_Id)
        {
            return BusinessLogic.BussinessLogic.GetProductByUnique_Id(Unique_Id);
        }

        public List<ProductDTO> GetProductsByAuthorId(int AuthorId)
        {
            return BusinessLogic.BussinessLogic.GetProductsByAuthorId(AuthorId);
        }

        public bool AddNewProduct(ProductDTO obj)
        {
            return BusinessLogic.BussinessLogic.AddNewProduct(obj);
        }

        public bool UpdateProduct(ProductDTO obj)
        {
            return BusinessLogic.BussinessLogic.UpdateProduct(obj);
        }

        public bool DeleteProduct(ProductDTO obj)
        {
            return BusinessLogic.BussinessLogic.DeleteProduct(obj);
        }


        public StaffDTO Authorize(string Email, string Password) {
            return BusinessLogic.BussinessLogic.Authorize(Email, Password);
        }
    }
}
