using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KTransmit
{
    [DataContract]
    public class Form1099KTransmitRequest
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public List<Guid> RecordIds { get; set; }
    }
}
