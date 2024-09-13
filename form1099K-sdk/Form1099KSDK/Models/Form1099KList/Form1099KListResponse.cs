using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KList
{
    [DataContract]
    public class Form1099KListResponse : BaseResponseStatus
    {
        [DataMember(Order = 2)]
        public List<Form1099KRecordsList> Form1099Records { get; set; }
    }
}
