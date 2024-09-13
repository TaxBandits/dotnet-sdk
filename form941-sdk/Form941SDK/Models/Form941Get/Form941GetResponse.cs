using Form941SDK.Models.Business;
using Form941SDK.Models.Form941Create;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Get
{
    [DataContract]
    public class Form941GetResponse
    {
        /// <summary>
        /// Record Identifier - Leave it blank for Create API.
        /// </summary>
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string SequenceId { get; set; }

        /// <summary>
        /// Return status details like Created, Transmitted, Accepted, Rejected.
        /// </summary>
        [DataMember]
        public string RecordStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Form941ReturnHeader ReturnHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>

        [DataMember]
        public Form941ReturnDataDetail ReturnData { get; set; }
        /// <summary>
        /// Return Number from IRS
        /// </summary>
        [DataMember]
        public string ReturnNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> ErrorMessages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }
    }
}
