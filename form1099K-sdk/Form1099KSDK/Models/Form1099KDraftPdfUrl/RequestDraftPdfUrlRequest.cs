using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KDraftPdfUrl
{
    [DataContract]
    public class RequestDraftPdfUrlRequest
    {
        [DataMember]
        public Guid? RecordId { get; set; }
    }
}
