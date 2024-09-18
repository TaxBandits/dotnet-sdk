using FormW9SDK.Models.Base;
using System.Runtime.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class W9StatusResponse
    {
        public List<Guid> SubmissionId { get; set; }

        [DataMember(Order = 1)]
        public RequesterBizInfo Requester { get; set; }

        [DataMember(Order = 2)]
        public string PayeeRef { get; set; }

        [DataMember(Order = 3)]
        public string Email { get; set; }

        [DataMember(Order = 4)]
        public int TotalRecords { get; set; }

        [DataMember(Order = 5)]
        public List<StatusInfo> Status { get; set; }

        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }
        public Guid UserId { get; set; }
        public Guid BusinessId { get; set; }
        public string TIN { get; set; }
    }
    public class StatusInfo
    {
        [DataMember]
        public Guid SubmissionId { get; set; }
        [DataMember]
        public Guid? DBAId { get; set; }
        [DataMember]
        public string DBARef { get; set; }
        [DataMember]
        public string W9Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public TINMatchINfo TINMatching { get; set; }
        [DataMember]
        public string FormW9RequestType { get; set; }

    }
}
