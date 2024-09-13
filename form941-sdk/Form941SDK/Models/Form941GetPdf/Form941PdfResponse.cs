using Amazon.S3.Model;
using Form941SDK.Models.Base;
using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941GetPdf
{
    [DataContract]
    public class Form941PdfResponse : BaseResponseStatus
    {

        /// <summary>
        /// Submission Identifier
        /// </summary>
        [DataMember(Order = 1)]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// It will return the PDF generation status.
        /// </summary>
        [DataMember(Order = 2)]
        public List<PdfRecord> Form941pdfRecords { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 3)]
        public List<ErrorV3> Errors { get; set; }

    }
}
