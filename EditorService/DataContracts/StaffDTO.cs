using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EditorService.DataContracts
{
    [DataContract(Namespace = "WcfService")]
    [Serializable]
    public class StaffDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Firstname { get; set; }

        [DataMember]
        public string Lastname { get; set; }

        
        public GenderDTO Gender { get; set; }

        [DataMember]
        public RoleDTO Role { get; set; }

        
        public string Personal_Id { get; set; }

        
        public DateTime Birth_Date { get; set; }

        
        public CountryDTO Country { get; set; }

        
        public CityDTO City { get; set; }

        
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }


        [StringLength(255)]
        public string AccountPassword { get; set; }
    }
}