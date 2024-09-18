using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KRequestPdfURL
{
    [DataContract]
    public class Form1099KRequestPdfUrlsResponse
    {
        [DataMember]
        public Form1099RequestPdfUrl Form1099KRecords { get; set; }
        [DataMember]
        public List<ErrorV3> Errors { get; set; }
    }
    [DataContract]
    public class Form1099RequestPdfUrl
    {
        [DataMember]
        public List<SuccessPdfUrlRecord> SuccessRecords { get; set; }
        [DataMember]
        public List<ErrorPdfUrlRecord> ErrorRecords { get; set; }
    }
    [DataContract]
    public class PrintCopyFile
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

    [DataContract]
    public class SuccessPdfUrlRecord
    {
        [DataMember]
        public PrintCopyFile Files { get; set; }
    }
    [DataContract]
    public class ErrorPdfUrlRecord
    {
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
