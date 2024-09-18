using Form1099MISCSDK.Models.Business;
using Form1099MISCSDK.Models.Form1099MISCCreate;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCGet
{
    [DataContract]
    public class Form1099MiscGetResponse
    {
        [DataMember]
        public SubmissionLevelManifestV2 SubmissionManifest { get; set; }
        [DataMember]
        public APIReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public List<Form1099MISCReturnData> ReturnData { get; set; }

    }
}
