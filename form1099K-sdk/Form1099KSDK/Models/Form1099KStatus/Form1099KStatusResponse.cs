using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KStatus
{
    [DataContract]
    public class Form1099KStatusResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Guid? BusinessId { get; set; }
        [DataMember(Order = 3)]
        public string PayerRef { get; set; }
        [DataMember(Order = 5)]
        public Form1099KStatusRecords Form1099Records { get; set; }
        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }

    }
}
