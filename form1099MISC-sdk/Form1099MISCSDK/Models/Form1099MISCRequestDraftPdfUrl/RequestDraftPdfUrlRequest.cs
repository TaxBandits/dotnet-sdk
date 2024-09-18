using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCRequestDraftPdfUrl
{
    [DataContract]
    public class RequestDraftPdfUrlRequest
    {
        [DataMember]
        public Guid? RecordId { get; set; }
    }
}
