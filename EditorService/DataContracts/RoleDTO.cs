﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EditorService.DataContracts
{
    [DataContract(Namespace = "WcfService")]
    [Serializable]
    public class RoleDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}