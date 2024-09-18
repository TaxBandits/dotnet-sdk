using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form941CreateRequest
    {
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        [DataMember]
        public List<Form941Details> Form941Records { get; set; }

    }
}
