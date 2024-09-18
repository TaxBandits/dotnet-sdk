using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using Form1099MISCSDK.Models.Form1099MISCDelete;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCTransmit
{
    [DataContract]
    public class TransmitForm1099Response : BaseResponseStatus
    {
        /// <summary>
        /// Submission ID
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// Form 1099 MISC records success and error status
        /// </summary>
        [DataMember(Order = 2)]
        public Form1099MISCResponseRecords Form1099Records { get; set; }

        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }
    }
}
