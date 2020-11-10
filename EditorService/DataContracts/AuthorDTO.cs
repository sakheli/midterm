using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EditorService.DataContracts
{
    [DataContract(Namespace = "WcfService")]
    [Serializable]
    public class AuthorDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? Unique_Id { get; set; }

        [DataMember]
        public string Firstname { get; set; }

        [DataMember]
        public string Lastname { get; set; }

        [DataMember]
        public GenderDTO Gender { get; set; }

        [DataMember]
        public string Personal_Id { get; set; }

        [DataMember]
        public DateTime Birth_Date { get; set; }

        [DataMember]
        public CountryDTO Country { get; set; }

        [DataMember]
        public CityDTO City { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public virtual List<ProductDTO> Products { get; set; }
    }
}