using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TINMatchingResponseRecords
    {
        [DataMember]
        public List<TINMatchingSuccessRecords> SuccessRecords { get; set; }
        [DataMember]
        public List<TINMatchingErrorRecords> ErrorRecords { get; set; }
    }

    [DataContract]
    public class TINMatchingSuccessRecords
    {
        [DataMember]
        public Guid RecordId { get; set; }
        [DataMember]
        public string SequenceId { get; set; }

        [DataMember]
        public Guid? RecipientId { get; set; }

        [DataMember]
        public string TINType { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public int NumOfAttemptsRmng { get; set; }

    }

    [DataContract]
    public class TINMatchingErrorRecords
    {
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string TINType { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public Guid? RecipientId { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }

    }
}
