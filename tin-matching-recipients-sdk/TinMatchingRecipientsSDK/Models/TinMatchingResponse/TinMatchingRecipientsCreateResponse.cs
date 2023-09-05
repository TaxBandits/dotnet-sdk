using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class TinMatchingRecipientsCreateResponse
    {
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Guid BusinessId { get; set; }
        [DataMember(Order = 3)]
        public TINMatchingResponseRecords TINMatchingRecords { get; set; }
        [DataMember(Order = 4)]
        public List<ErrorV3> Errors { get; set; }
       
    }
}
