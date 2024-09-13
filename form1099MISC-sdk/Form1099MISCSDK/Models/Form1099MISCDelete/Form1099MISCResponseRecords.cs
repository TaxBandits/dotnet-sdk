using Form1099MISCSDK.Models.Base;
using Form1099MISCSDK.Models.Form1099MISCCreate;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCDelete
{
    [DataContract]
    public class Form1099MISCResponseRecords
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
