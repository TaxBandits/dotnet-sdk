using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class Form941RecordResponse
    {
        [DataMember]
        public List<Form941RecordSuccessStatus> SuccessRecords { get; set; }
        [DataMember]
        public List<Form941RecordErrorStatus> ErrorRecords { get; set; }

    }

    [DataContract]
    public class Form941RecordErrorStatus
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }

    }

    [DataContract]
    public class Form941RecordSuccessStatus
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string RecordStatus { get; set; }
        [DataMember]

        public string CreatedTs { get; set; }
        [DataMember]
        public string UpdatedTs { get; set; }
    }
}
