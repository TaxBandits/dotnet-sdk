using Form1099NecSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NEC
{
    [DataContract]
    public class ValidateFormNECResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public List<ErrorNecRecords> ErrorRecords { get; set; }

        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }
 
}
