using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECTransmit
{
    [DataContract]
    public class Form1099NecTransmitRequest
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public List<Guid> RecordIds { get; set; }
       
    }
}
