using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingRequest
{
    [DataContract]
    public class TINMatchingBusiness
    {
        [DataMember]
        public Guid? BusinessId { get; set; }
        [DataMember]
        public string BusinessNm { get; set; }
        [DataMember]
        public string TIN { get; set; }
    }
}
