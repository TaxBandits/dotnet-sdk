using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KCreate
{
    [DataContract]
    public class Form1099KRecords
    {
        [DataMember]
        public List<SuccessKRecords> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorKRecords> ErrorRecords { get; set; }
    }
    [DataContract]
    public class SuccessKRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public Guid? RecipientId { get; set; }
        [DataMember]
        public string AccountNum { get; set; }
        [DataMember]
        public FederalReturn FederalReturn { get; set; }
        [DataMember]
        public List<StateReturns> StateReturns { get; set; }
        [DataMember]
        public PostalResponse Postal { get; set; }
        [DataMember]
        public OnlineAccessResponse OnlineAccess { get; set; }
    }
    [DataContract]
    public class ErrorKRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class FederalReturn
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
    public class StateReturns
    {
        [DataMember]
        public string StateCd { get; set; }
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
    public class PostalResponse
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public string Info { get; set; }
    }
    [DataContract]
    public class OnlineAccessResponse
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Info { get; set; }
    }
}
