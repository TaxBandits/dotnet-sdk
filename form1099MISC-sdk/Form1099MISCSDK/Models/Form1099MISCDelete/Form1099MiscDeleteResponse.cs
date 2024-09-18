using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCDelete
{
    [DataContract]
    public class Form1099MiscDeleteResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// List of all Record Status
        /// </summary>
        [DataMember(Order = 2)]
        public Form1099MISCResponseRecords Form1099Records { get; set; }
        [DataMember(Order = 4)]
        public List<ErrorV3> Errors { get; set; }
    }
}
