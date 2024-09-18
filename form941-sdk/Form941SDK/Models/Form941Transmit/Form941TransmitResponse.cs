using Amazon.S3.Model;
using Form941SDK.Models.Base;
using Form941SDK.Models.Form941Update;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Transmit
{
    [DataContract]
    public class Form941TransmitResponse : BaseResponseStatus
    {
        /// <summary>
        /// Submission ID
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// Form 941 records success and error status
        /// </summary>
        [DataMember(Order = 2)]
        public Form941Records Form941Records { get; set; }

        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }

    }
}
