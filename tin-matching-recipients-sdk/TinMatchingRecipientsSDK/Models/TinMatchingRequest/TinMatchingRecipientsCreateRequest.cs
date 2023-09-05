using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingRequest
{
    public class TinMatchingRecipientsCreateRequest
    {
        [DataMember]
        public TINMatchingCreateRecipient TINMatchingDetails { get; set; }

    }
}
