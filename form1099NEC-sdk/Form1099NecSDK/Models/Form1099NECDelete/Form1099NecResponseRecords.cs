using Form1099NecSDK.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECDelete
{
    [DataContract]
    public class Form1099NecResponseRecords
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
