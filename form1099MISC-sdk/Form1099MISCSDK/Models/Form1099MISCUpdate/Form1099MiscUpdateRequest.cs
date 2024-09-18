using Form1099MISCSDK.Models.Business;
using Form1099MISCSDK.Models.Form1099MISCCreate;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCUpdate
{
    [DataContract]
    public class Form1099MiscUpdateRequest
    {
        [DataMember]
        public SubmissionLevelManifestV2 SubmissionManiFest { get; set; }
        [DataMember]
        public APIReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public List<Form1099MISCReturnData> ReturnData { get; set; }

    }
}
