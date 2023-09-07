using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECRequestPdfUrl
{
    [DataContract]
    public class RequestPdfURLRequest
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public List<RequestRecordIds> RecordIds { get; set; }
    }
    [DataContract]
    public class RequestRecordIds
    {
        [DataMember]
        public Guid? RecordId { get; set; }
    }
}
