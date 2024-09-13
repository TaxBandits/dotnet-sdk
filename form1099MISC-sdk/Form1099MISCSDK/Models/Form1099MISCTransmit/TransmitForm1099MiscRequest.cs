using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCTransmit
{
    [DataContract]
    public class TransmitForm1099MiscRequest
    {
        /// <summary>
        /// Submission ID
        /// </summary>
        [DataMember]
        [Required]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// List of all record IDs
        /// </summary>
        [DataMember]
        public List<Guid> RecordIds { get; set; }


    }
}
