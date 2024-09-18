using FormW9SDK.Models.Base;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class FormW9ListResponse
    {


        /// <summary>
        /// Requester Details
        /// </summary>
        [DataMember(Order = 1)]
        public RequesterBizInfo Requester { get; set; }
        [DataMember(Order = 2)]
        public List<FormW9RecordList> FormW9Records { get; set; }

        /// <summary>
        /// Total number of Records
        /// </summary>
        [DataMember(Order = 3)]
        public int TotalRecords { get; set; }
        /// <summary>
        /// Total number of pages
        /// </summary>
        [DataMember(Order = 4)]
        public int TotalPages { get; set; }
        /// <summary>
        /// Page number
        /// </summary>
        [DataMember(Order = 5)]
        public int Page { get; set; }

        /// <summary>
        /// Range: 10, 25, 50, 100
        /// </summary>
        [DataMember(Order = 6)]
        public int PageSize { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 7)]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class RequesterBizInfo
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
    }
    [DataContract]
    public class FormW9RecordList
    {

        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public Guid? DBAId { get; set; }
        [DataMember]
        public string DBARef { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        public string PayeeRef { get; set; }

        /// <summary>
        /// Name 
        /// </summary>
        [DataMember]
        public string Line1Nm { get; set; }
        [DataMember]
        public string FirstNm { get; set; }
        [DataMember]
        public string LastNm { get; set; }
        [DataMember]
        public string MiddleNm { get; set; }
        [DataMember]
        public string Suffix { get; set; }
        /// <summary>
        /// Record Status (Created, Sent, Sending, Completed, Declined)
        /// </summary>
        [DataMember]
        public string W9Status { get; set; }
        [DataMember]
        /// <summary>
        /// Status Ts
        /// </summary>
        public string StatusTs { get; set; }
        [DataMember]
        public TINMatchINfo TINMatching { get; set; }
        ///// <summary>
        ///// Declined Reason
        ///// </summary>
        //[DataMember]
        //public string DeclinedReason { get; set; }
        /// <summary>
        /// PdfUrl
        /// </summary>
        [DataMember]
        [DefaultValue("NA")]
        [JsonProperty("PdfUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]

        public string PdfUrl { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Request Type
        /// </summary>
        [DataMember]
        public string FormW9RequestType { get; set; }

    }
    public class TINMatchINfo
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
}
