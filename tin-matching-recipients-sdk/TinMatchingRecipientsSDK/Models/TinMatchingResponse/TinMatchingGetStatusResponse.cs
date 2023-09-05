using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TinMatchingGetStatusResponse
    {


        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// Record Identifier
        /// </summary>
        [DataMember(Order = 2)]
        public Guid RecordId { get; set; }
        /// <summary>
        /// Sequence Id 
        /// </summary>
        [DataMember(Order = 3)]
        public string SequenceId { get; set; }
        [DataMember(Order = 4)]
        public Guid? RecipientId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember(Order = 5)]
        public string Name { get; set; }
        /// <summary>
        /// EIN/SSN
        /// </summary>
        [DataMember(Order = 6)]
        public string TINType { get; set; }
        /// <summary>
        /// Tax Identification Number 
        /// </summary>
        [DataMember(Order = 7)]
        public string TIN { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        [DataMember(Order = 8)]
        public string Status { get; set; }
        /// <summary>
        /// Status Timestamp
        /// </summary>
        [DataMember(Order = 9)]
        public string StatusTs { get; set; }
        /// <summary>
        /// Remaining no.of Attempts
        /// </summary>
        [DataMember(Order = 10)]
        public int? NumOfAttemptsRmng { get; set; }
        /// <summary>
        /// Errors
        /// </summary>
        [DataMember(Order = 11)]
        public List<ErrorV3> Errors { get; set; }
    }
}
