using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Form1099MISCCreate
{
    [DataContract]
    public class Form1099MISCReturnData
    {
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public bool? IsPostal { get; set; }
        [DataMember]
        public bool? IsOnlineAccess { get; set; }
        [DataMember]
        public Recipient Recipient { get; set; }
        [DataMember]
        public Form1099MiscDetails MISCFormData { get; set; }
    }
}
