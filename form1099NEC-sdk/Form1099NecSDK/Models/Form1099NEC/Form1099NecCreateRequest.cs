using Form1099NecSDK.Models.Business;
using Form1099NecSDK.Models.StateRecon;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NEC
{

    [DataContract]
    public class Form1099NecCreateRequest
    {
        [DataMember]
        public SubmissionLevelManifestV2 SubmissionManiFest { get; set; }
        [DataMember]
        public APIReturnHeader ReturnHeader { get; set; }
        [DataMember]
        public List<NecReturnData> ReturnData { get; set; }
        [DataMember]
        public NECStateRecon StateReconData { get; set; }

    }
    [DataContract]
    public class SubmissionLevelManifestV2
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public string TaxYear { get; set; }
        [DataMember]
        public bool? IsFederalFiling { get; set; }
        [JsonIgnore]
        public bool IsFederalFilingNullable { get { return IsFederalFiling ?? false; } set { IsFederalFiling = value; } }
        [DataMember]
        public bool? IsStateFiling { get; set; } [DataMember]
        [JsonIgnore]
        public bool IsStateFilingNullable { get { return IsStateFiling ?? false; } set { IsStateFiling = value; } }
        [DataMember]
        public bool? IsPostal { get; set; }
        [JsonIgnore]
        public bool IsPostalNullable { get { return IsPostal ?? false; } set { IsPostal = value; } }
        [DataMember]
        public bool? IsOnlineAccess { get; set; }
        [JsonIgnore]
        public bool IsOnlineAccessNullable { get { return IsOnlineAccess ?? false; } set { IsOnlineAccess = value; } }
    }
}
