using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KStatus
{
    [DataContract]
    public class Form1099KStatusRecords
    {
        [DataMember]
        public List<SuccessStatusRecords> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorStatusRecords> ErrorRecords { get; set; }
    }
    [DataContract]
    public class SuccessStatusRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public Guid? RecipientId { get; set; }
        [DataMember]
        public FederalResponse FederalReturn { get; set; }
        [DataMember]
        public PostalResponses PostalResponse { get; set; }
        [DataMember]
        public OnlineAccessResponses OnlineAccess { get; set; }
    }
    [DataContract]
    public class ErrorStatusRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class FederalResponse
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public string Info { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class PostalResponses
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public string Info { get; set; }
    }
    [DataContract]
    public class OnlineAccessResponses
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Info { get; set; }
    }
}
