using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingRequest
{
    [DataContract]
    public class TINMatchingCreateRecipient
    {
        [DataMember]
        public TINMatchingBusiness Business { get; set; }

        [DataMember]
        public List<TINMatchingRecipients> Recipients { get; set; }
    }
}
