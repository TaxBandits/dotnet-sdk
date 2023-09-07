using Form1099NecSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECDraftPdfUrl
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
