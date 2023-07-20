using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TinMatchingCancelResponse
    {
       
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// List of all Record Status
        /// </summary>
        [DataMember(Order = 2)]
        public TinMatchingCancelResponseRecords TINMatchingRecords { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
