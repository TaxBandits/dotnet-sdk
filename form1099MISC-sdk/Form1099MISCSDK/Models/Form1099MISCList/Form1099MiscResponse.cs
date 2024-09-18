using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCList
{
    [DataContract]
    public class Form1099MiscResponse : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public string Form1099Type { get; set; }
        /// <summary>
        /// A detailed information about the Business, Employees and Form 1099 MISC records
        /// </summary>
        [DataMember(Order = 2)]
        public List<Form1099MiscListResponse> Form1099Records { get; set; }
    }
}
