using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KDelete
{
    [DataContract]
    public class Form1099KResponseRecords
    {
        [DataMember]
        public List<SuccessResponse> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorResponse> ErrorRecords { get; set; }
    }
    [DataContract]
    public class SuccessResponse
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
    }
    [DataContract]
    public class ErrorResponse
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
}
