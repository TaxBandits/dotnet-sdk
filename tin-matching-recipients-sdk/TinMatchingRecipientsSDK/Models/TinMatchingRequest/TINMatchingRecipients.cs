using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingRequest
{
    [DataContract]
    public class TINMatchingRecipients
    {
        [DataMember]
        public string SequenceId { get; set; }

        [DataMember]
        public Guid? RecipientId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string TINType { get; set; }

        [DataMember]
        public string TIN { get; set; }

    }
 
}
