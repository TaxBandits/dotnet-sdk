using Form1099NecSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECDelete
{
    [DataContract]
    public class Form1099NecDeleteResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Form1099NecResponseRecords Form1099Records { get; set; }

        [DataMember(Order = 4)]
        public List<ErrorV3> Errors { get; set; }
    }
}
