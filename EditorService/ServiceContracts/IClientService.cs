using EditorService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace EditorService.ServiceContracts
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllAuthores", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<AuthorDTO> GetAllAuthores();

        [OperationContract]
        [WebGet(UriTemplate = "/GetAuthorByUnique_Id/{Unique_Id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        AuthorDTO GetAuthorByUnique_Id(int Unique_Id);

        [OperationContract]
        [WebGet(UriTemplate = "/AddNewAuthor/{values}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool AddNewAuthor(AuthorDTO obj);


        [OperationContract]
        [WebGet(UriTemplate = "/UpdateAuthor/{values}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateAuthor(AuthorDTO obj);

        [OperationContract]
        [WebGet(UriTemplate = "/DeleteAuthor/{values}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteAuthor(AuthorDTO obj);
    }
}

[DataContract]
public class CompositeType
{
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}