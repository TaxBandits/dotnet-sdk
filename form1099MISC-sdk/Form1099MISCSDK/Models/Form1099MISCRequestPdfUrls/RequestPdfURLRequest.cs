using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCRequestPdfUrls
{
    [DataContract]
    public class RequestPdfURLRequest
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public List<RequestRecordIds> RecordIds { get; set; }
    }
    public class RequestRecordIds
    {
        [DataMember]
        public Guid? RecordId { get; set; }
    }
}
