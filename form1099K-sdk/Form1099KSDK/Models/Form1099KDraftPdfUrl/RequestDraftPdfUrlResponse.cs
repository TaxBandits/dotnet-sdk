using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KDraftPdfUrl
{
    [DataContract]
    public class RequestDraftPdfUrlResponse
    {
        [DataMember]
        public string DraftPdfUrl { get; set; }
        [DataMember]
        public ErrorV3 Error { get; set; }
    }
}
