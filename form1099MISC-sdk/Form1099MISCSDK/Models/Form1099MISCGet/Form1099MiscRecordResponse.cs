using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCGet
{
    [DataContract]
    public class Form1099MiscRecordResponse : BaseResponseStatus
    {
        /// <summary>
        /// A detailed information about the Business, Employees and Form 1099-MISC records
        /// </summary>
        [DataMember(Order = 1)]
        public Form1099MiscGetResponse Form1099Records { get; set; }
    }
}
