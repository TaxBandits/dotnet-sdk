using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Form1099KCreate
{
    [DataContract]
    public class KReturnData
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
        public KFormDetails KFormData { get; set; }
    }
}
