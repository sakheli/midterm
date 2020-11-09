using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EditorService.DataContracts
{
    [DataContract(Namespace = "WcfService")]
    [Serializable]
    public class GenderDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Gender1 { get; set; }
    }
}