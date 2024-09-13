using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCCreate
{
    [DataContract]
    public class Form1099MiscCreateResponse : BaseResponseStatus
    {
        /// <summary>
        /// Submission ID
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }

        [DataMember(Order = 2)]
        public Guid? BusinessId { get; set; }

        /// <summary>
        /// Form 1099 - MISC records success and error status
        /// </summary>
        [DataMember(Order = 5)]
        public Form1099Records Form1099Records { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }
    }
}
