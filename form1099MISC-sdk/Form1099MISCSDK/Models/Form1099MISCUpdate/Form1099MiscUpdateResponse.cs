using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCUpdate
{
    [DataContract]
    public class Form1099MiscUpdateResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 3)]
        public Guid? BusinessId { get; set; }
        [DataMember(Order = 6)]
        public Form1099MiscRecords Form1099Records { get; set; }
        [DataMember(Order = 7)]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class Form1099MiscRecords
    {
        [DataMember]
        public List<SuccessRecords> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorRecords> ErrorRecords { get; set; }
    }

    [DataContract]
    public class SuccessRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
    }

    [DataContract]
    public class ErrorRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
}
