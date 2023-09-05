using System.Runtime.Serialization;

namespace TinMatchingRecipientsSDK.Models.TinMatchingResponse
{
    [DataContract]
    public class ErrorV3
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
