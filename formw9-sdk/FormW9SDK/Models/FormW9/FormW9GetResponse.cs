using FormW9SDK.Models.Base;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class FormW9GetResponse
    {

        [DataMember]
        public Guid SubmissionId { get; set; }

        [DataMember]
        public RequesterInfo Requester { get; set; }

        [DataMember]
        public string PayeeRef { get; set; }
        [DataMember]
        public Guid RecipientId { get; set; }
        [DataMember]
        public string W9Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public TINMatchINfo TINMatching { get; set; }
        [DataMember]
        public string FormW9RequestType { get; set; }

        //Setting DeafultValue="NA" for removing this node in response
        [DefaultValue("NA")]
        [JsonProperty("PdfUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember]
        public string PdfUrl { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
}
