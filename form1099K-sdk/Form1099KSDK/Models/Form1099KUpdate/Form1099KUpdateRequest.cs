using Form1099KSDK.Models.Business;
using Form1099KSDK.Models.Form1099KCreate;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KUpdate
{
    [DataContract]
    public class Form1099KUpdateRequest
    {
        [DataMember]
        public SubmissionLevelManifestV2 SubmissionManifest { get; set; }
        [DataMember]
        public APIReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public List<KReturnData> ReturnData { get; set; }
    }
}
