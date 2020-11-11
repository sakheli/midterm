using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EditorService.DataContracts
{
    [DataContract(Namespace = "WcfService")]
    [Serializable]
    public class ProductDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? Unique_Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public ProductTypeDTO ProductType { get; set; }

        [DataMember]
        public string ISBN { get; set; }

        [DataMember]
        public DateTime Publish_Date { get; set; }

        [DataMember]
        public Publishing_HouseDTO PublishingHouse { get; set; }

        [DataMember]
        public int? Pages { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public virtual List<AuthorDTO> Authors { get; set; }
    }
}