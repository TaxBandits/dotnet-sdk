using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KGet
{
    [DataContract]
    public class Form1099KGetResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Form1099KRecordResponse Form1099Records { get; set; }
        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }
}
