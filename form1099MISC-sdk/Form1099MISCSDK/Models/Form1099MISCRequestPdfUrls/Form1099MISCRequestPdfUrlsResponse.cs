using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCRequestPdfUrls
{
    [DataContract]
    public class Form1099MISCRequestPdfUrlsResponse
    {
        [DataMember]
        public Form1099RequestPdfUrls Form1099MISCRecords { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class Form1099RequestPdfUrls
    {
        [DataMember]
        public List<SuccessPdfUrlRecords> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorPdfUrlRecords> ErrorRecords { get; set; }
    }
    [DataContract]
    public class SuccessPdfUrlRecords
    {
        [DataMember]
        public PrintCopyFiles Files { get; set; }
    }
    [DataContract]
    public class ErrorPdfUrlRecords
    {
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
    [DataContract]
    public class PrintCopyFiles
    {
        [DataMember]
        public MaskedType Copy1 { get; set; }
        [DataMember]
        public MaskedType Copy2 { get; set; }
        [DataMember]
        public MaskedType CopyB { get; set; }
        [DataMember]
        public MaskedType CopyC { get; set; }
    }
    [DataContract]
    public class MaskedType
    {
        [DataMember]
        public string Unmasked { get; set; }
        [DataMember]
        public string Masked { get; set; }
    }
}
