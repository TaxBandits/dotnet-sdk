using Amazon.S3.Model;
using Form941SDK.Models.Form941Create;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Update
{
    public class Form941UpdateRequest
    {
        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Form941Details> Form941Records { get; set; }
    }
}
