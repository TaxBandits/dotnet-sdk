using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KCreate
{
    [DataContract]
    public class Form1099KValidateFormResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public List<ErrorKRecords> ErrorRecords { get; set; }
        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }
}
