using System.Runtime.Serialization;
using TinMatchingRecipientsSDK.Models.TinMatchingRequest;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TinMatchingListResponse
    {

        /// <summary>
        /// Requester Details
        /// </summary>
        [DataMember(Order = 1)]
        public TINMatchingBusiness Business { get; set; }
        [DataMember(Order = 2)]
        public List<TINMatchingRecords> TINMatchingRecords { get; set; }
        /// <summary>
        /// Total number of Records
        /// </summary>
        [DataMember(Order = 3)]
        public int TotalRecords { get; set; }
        /// <summary>
        /// Total number of pages
        /// </summary>
        [DataMember(Order = 4)]
        public int TotalPages { get; set; }
        /// <summary>
        /// Page number
        /// </summary>
        [DataMember(Order = 5)]
        public int Page { get; set; }

        /// <summary>
        /// Range: 10, 25, 50, 100
        /// </summary>
        [DataMember(Order = 6)]
        public int PageSize { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 7)]
        public List<ErrorV3> Errors { get; set; }
    }
}
