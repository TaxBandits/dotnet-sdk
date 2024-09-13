using FormW9SDK.Models.Base;
using System.Runtime.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class W9RequestByEmailResponse
    {
        [DataMember(Order = 1)]
        public Guid? SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public RequesterInfo Requester { get; set; }
        [DataMember(Order = 3)]
        public FormW9EmailRecord FormW9Records { get; set; }
        [DataMember(Order = 4)]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class RequesterInfo
    {
        [DataMember]
        public Guid BusinessId { get; set; }
        [DataMember]
        public string PayerRef { get; set; }
        [DataMember]
        public string BusinessNm { get; set; }
        [DataMember]
        public string FirstNm { get; set; }

        [DataMember]
        public string MiddleNm { get; set; }
        [DataMember]
        public string LastNm { get; set; }
        [DataMember]
        public string Suffix { get; set; }
        [DataMember]
        public string TINType { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public Guid? DBAId { get; set; }
        [DataMember]
        public string DBARef { get; set; }
    }
    [DataContract]
    public class FormW9EmailRecord
    {
        [DataMember]
        public List<FormW9SuccessRecords> SuccessRecords { get; set; }

        [DataMember]
        public List<FormW9ErrorRecords> ErrorRecords { get; set; }
    }

    [DataContract]
    public class FormW9ErrorRecords
    {
        [DataMember]
        public string PayeeRef { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FormW9SuccessRecords
    {
        [DataMember]
        public string PayeeRef { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string W9Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
    }
}
