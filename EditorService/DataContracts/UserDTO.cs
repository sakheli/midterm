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
    public class UserDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public RoleDTO Role { get; set; }

        [DataMember]
        public string Email { get; set; }


        [StringLength(255)]
        public string Password { get; set; }
    }
}