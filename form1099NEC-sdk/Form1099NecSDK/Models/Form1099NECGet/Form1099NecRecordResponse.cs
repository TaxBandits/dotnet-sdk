using Form1099NecSDK.Models.Business;
using Form1099NecSDK.Models.Form1099NEC;
using Form1099NecSDK.Models.StateRecon;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECGet
{
    [DataContract]
    public class Form1099NecRecordResponse
    {
        [DataMember]
        public SubmissionLevelManifestV2 SubmissionManifest { get; set; }
        [DataMember]
        public APIReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public List<NecReturnData> ReturnData { get; set; }
        [DataMember]
        public NECStateRecon StateReconData { get; set; }
    }
}
