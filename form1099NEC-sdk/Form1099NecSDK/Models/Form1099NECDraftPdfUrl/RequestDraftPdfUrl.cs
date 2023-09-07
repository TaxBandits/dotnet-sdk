using System.Runtime.Serialization;

namespace Form1099NecSDK.Models.Form1099NECDraftPdfUrl
{
    [DataContract]
    public class RequestDraftPdfUrl
    {

        [DataMember]
        public Guid? RecordId { get; set; }
    }
}
