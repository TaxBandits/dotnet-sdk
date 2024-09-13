using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class W9RequestByEmailRequest
    {
        [DataMember]
        public TinMatchingManifest SubmissionManifest { get; set; }
        [DataMember]
        public BusinessRequestInfo Requester { get; set; }
        [DataMember]
        public List<RecipientEmailRequest> Recipients { get; set; }
        [DataMember]
        public Guid? WebhookRef { get; set; }
    }
    [DataContract]
    public class TinMatchingManifest
    {
        [DataMember]
        public bool? IsTINMatching { get; set; }
    }
    [DataContract]
    public class BusinessRequestInfo
    {
        [DataMember]
        public Guid? BusinessId { get; set; }
        [DataMember]
        public string PayerRef { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public Guid? DBAId { get; set; }
        [DataMember]
        public string DBARef { get; set; }
        [JsonIgnore]
        public string BusinessName { get; set; }

    }

    [DataContract]
    public class RecipientEmailRequest
    {
        [DataMember]
        public string PayeeRef { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }

    }


}
