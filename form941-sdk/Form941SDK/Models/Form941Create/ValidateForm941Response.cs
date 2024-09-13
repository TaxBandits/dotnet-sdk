using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Create
{
    [DataContract]
    public class ValidateForm941Response : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public List<ValidateForm941Errors> ErrorRecords { get; set; }
        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }

    [DataContract]
    public class ValidateForm941Errors
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }

    }
}
