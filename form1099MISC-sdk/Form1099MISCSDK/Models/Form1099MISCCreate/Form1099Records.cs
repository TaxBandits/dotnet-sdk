using Form1099MISCSDK.Models.Base;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCCreate
{
    [DataContract]
    public class Form1099Records
    {
        /// <summary>
        /// It will show the detailed information about the success status of Form 1099 Records
        /// </summary>
        [DataMember]
        public List<SuccessMISCRecords> SuccessRecords { get; set; }

        /// <summary>
        /// It will show the detailed information about the error status of Form 1099 Records
        /// </summary>
        [DataMember]
        public List<ErrorMISCRecords> ErrorRecords { get; set; }
    }
    [DataContract]
    public class SuccessMISCRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public Guid? RecipientId { get; set; }
        //Setting DeafultValue="NA" for removing this node in response
        [DefaultValue("NA")]
        [JsonProperty("AccountNum", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
    public class ErrorMISCRecords
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
