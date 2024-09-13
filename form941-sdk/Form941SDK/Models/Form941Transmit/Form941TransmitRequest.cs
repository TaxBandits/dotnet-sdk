using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Transmit
{
    [DataContract]
    public class Form941TransmitRequest
    {
        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember]
        [Required]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// List of all record Identifiers
        /// </summary>
        [DataMember]
        public List<Guid> RecordIds { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        public Guid UserId { get; set; }

        public string IpAddress { get; set; }
        public byte FormId { get; set; }
    }
}
