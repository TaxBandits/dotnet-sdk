using Amazon.S3.Model;
using Form941SDK.Models.Base;
using Form941SDK.Models.Form941Update;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941Delete
{
    [DataContract]
    public class Form941DeleteResponse : BaseResponseStatus
    {
        /// <summary>
        /// List of all Record Status
        /// </summary>
        [DataMember(Order = 1)]
        public Form941Records Form941Records { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }
}
