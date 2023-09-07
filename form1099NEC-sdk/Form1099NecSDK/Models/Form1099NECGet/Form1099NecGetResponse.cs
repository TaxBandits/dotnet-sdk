using Form1099NecSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECGet
{
    [DataContract]
    public class Form1099NecGetResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Form1099NecRecordResponse Form1099Records { get; set; }
    }
}
