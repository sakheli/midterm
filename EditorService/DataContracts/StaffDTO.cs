using System;
using System.Collections.Generic;
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

        
        public int? Id_Gender { get; set; }

        [DataMember]
        public int Id_Role { get; set; }

        
        public string Personal_Id { get; set; }

        
        public DateTime Birth_Date { get; set; }

        
        public int? Id_Country { get; set; }

        
        public int? Id_City { get; set; }

        
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

    }
}