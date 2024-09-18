using Form1099KSDK.Models.Base;
using Form1099KSDK.Models.Form1099KDelete;
using Form1099KSDK.Models.Form1099KGet;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KTransmit
{
    [DataContract]
    public class Form1099KTransmitResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Form1099KResponseRecords Form1099Records { get; set; }
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
