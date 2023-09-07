using Form1099NecSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NecList
{
    [DataContract]
    public class Form1099NecListResponse : BaseResponseStatus
    {
        [DataMember(Order = 2)]
        public List<Form1099NecList> Form1099Records { get; set; }
    }
}
