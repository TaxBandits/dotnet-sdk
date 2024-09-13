using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Update
{
    [DataContract]
    public class Form941Records
    {
        /// <summary>
        /// It will show the detailed information about the success status of Form 941 Records
        /// </summary>
        [DataMember]
        public List<Form941RecordSuccessStatus> SuccessRecords { get; set; }

        /// <summary>
        /// It will show the detailed information about the error status of Form 941 Records
        /// </summary>
        [DataMember]
        public List<Form941RecordErrorStatus> ErrorRecords { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Form941RecordErrorStatus
    {

        /// <summary>
        /// This identifies the sequence on the record sent in the pay load. When errors occur we will send the errors attached to particular sequence. Required
        /// </summary>
        [DataMember]
        public string SequenceId { get; set; }

        /// <summary>
        /// Record Identifier
        /// </summary>
        [DataMember]
        public Guid? RecordId { get; set; }

        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember]
        public List<ErrorV3> Errors { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Form941RecordSuccessStatus
    {
        /// <summary>
        /// This identifies the sequence on the record sent in the pay load. When errors occur we will send the errors attached to particular sequence. Required
        /// </summary>
        [DataMember]
        public string SequenceId { get; set; }

        /// <summary>
        /// Record Identifier
        /// </summary>
        [DataMember]
        public Guid? RecordId { get; set; }

        /// <summary>
        /// Return status details like Created, Transmitted, Accepted, Rejected.
        /// </summary>
        [DataMember]
        public string RecordStatus { get; set; }

        /// <summary>
        /// Return created date and time
        /// </summary>
        [DataMember]
        public string CreatedTs { get; set; }

        /// <summary>
        /// Return updated date and time
        /// </summary>
        [DataMember]
        public string UpdatedTs { get; set; }
    }
}
