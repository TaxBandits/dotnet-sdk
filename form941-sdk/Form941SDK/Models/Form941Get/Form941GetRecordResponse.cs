using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Get
{
    [DataContract]
    public class Form941GetRecordResponse:BaseResponseStatus
    {
        /// <summary>
        /// Submission Id
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// A detailed information about the Business, Employees and Form 941 records
        /// </summary>
        [DataMember(Order = 2)]
        public List<Form941GetResponse> Form941Records { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
