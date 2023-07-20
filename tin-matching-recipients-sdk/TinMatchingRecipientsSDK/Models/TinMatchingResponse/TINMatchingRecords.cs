using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    public class TINMatchingRecords
    {
        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// Record Identifier
        /// </summary>
        [DataMember]
        public Guid RecordId { get; set; }
        /// <summary>
        /// Sequence Id 
        /// </summary>
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Guid? RecipientId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// EIN/SSN
        /// </summary>
        [DataMember]
        public string TINType { get; set; }
        /// <summary>
        /// Tax Identification Number 
        /// </summary>
        [DataMember]
        public string TIN { get; set; }
        /// <summary>
        /// Remaining no.of Attempts
        /// </summary>
        [DataMember]
        public int? NumOfAttemptsRmng { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// Status Timestamp
        /// </summary>
        [DataMember]
        public string StatusTs { get; set; }

    }
}
