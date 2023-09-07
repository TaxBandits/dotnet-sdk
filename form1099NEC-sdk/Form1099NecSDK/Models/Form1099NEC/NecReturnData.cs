using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NEC
{
    [DataContract]
    public class NecReturnData
    {
        [DataMember]
        public Guid? RecordId { get; set; }
        [DataMember]
        public string SequenceId { get; set; }
        [DataMember]
        public Recipient Recipient { get; set; }
        [DataMember]
        public NecFormDetails NECFormData { get; set; }
    }
}
