using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCRequestDraftPdfUrl
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
