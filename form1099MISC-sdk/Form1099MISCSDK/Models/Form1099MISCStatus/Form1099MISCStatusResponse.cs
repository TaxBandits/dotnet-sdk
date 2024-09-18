using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using Form1099MISCSDK.Models.Form1099MISCCreate;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCStatus
{
    [DataContract]
    public class Form1099MISCStatusResponse : BaseResponseStatus
    {
        /// <summary>
        /// Submission Id
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        [DataMember(Order = 2)]
        public Guid? BusinessId { get; set; }
        [DataMember(Order = 3)]
        public string PayerRef { get; set; }
        /// <summary>
        /// Record Id
        /// </summary>
        [DataMember(Order = 5)]
        public Form1099Records Form1099Records { get; set; }
        /// <summary>
        ///  It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 6)]
        public List<ErrorV3> Errors { get; set; }
    }
}
