using Amazon.S3.Model;
using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCCreate
{
    [DataContract]
    public class ValidateFormResponse1099MISC : BaseResponseStatus
    {
        [DataMember(Order = 1)]
        public List<ErrorMISCRecords> ErrorRecords { get; set; }

        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }
}
