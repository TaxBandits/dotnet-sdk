using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form941CreateResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Form941RecordResponse Form941Records { get; set; }
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
