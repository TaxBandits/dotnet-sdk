using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TinMatchingCancelResponseRecords
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
        public string RequestedType { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
    }

    [DataContract]
    public class ErrorResponse
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public string RequestedType { get; set; }
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
}
