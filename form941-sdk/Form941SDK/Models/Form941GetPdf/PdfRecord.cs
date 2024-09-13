using System.Runtime.Serialization;

namespace Form941SDK.Models.Form941GetPdf
{
    [DataContract]
    public class PdfRecord
    {
        /// <summary>
        /// Record Identifier
        /// </summary>
        [DataMember]
        public Guid RecordId { get; set; }
        [DataMember]
        public string SequenceId { get; set; }

        /// <summary>
        /// It will show the message that the request has been successfully received to generate the PDF and you will be notified with the URL to download the PDF.
        /// </summary>
        [DataMember]
        public string Form941pdf { get; set; }
    }
}
