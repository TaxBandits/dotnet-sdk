using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KCreate
{
    [DataContract]
    public class Form1099KCreateResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Guid? BusinessId { get; set; }
        [DataMember(Order = 5)]
        public Form1099KRecords Form1099Records { get; set; }
        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }
    }
}
