using Form941SDK.Models.Business;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form941Details
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public Form941ReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public Form941ReturnDataDetail ReturnData { get; set; }

    }
}
