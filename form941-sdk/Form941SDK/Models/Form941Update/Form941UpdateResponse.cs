using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Update
{
    [DataContract]
    public class Form941UpdateResponse:BaseResponseStatus
    {
        /// <summary>
        /// Submission Id
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Order = 2)]
        public Form941Records Form941Records { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
