using FormW9SDK.Models.Base;
using System.Runtime.Serialization;

namespace FormW9SDK.Models.FormW9
{
    [DataContract]
    public class W9CommonDeleteResponse
    {
        [DataMember(Order = 1)]
        public List<FormW9DeleteSucessRecord> FormW9Records { get; set; }
        [DataMember(Order = 2)]
        public List<ErrorV3> Errors { get; set; }
    }



    [DataContract]
    public class FormW9DeleteSucessRecord
    {
        [DataMember]
        public Guid? SubmissionId { get; set; }
        [DataMember]
        public string PayeeRef { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string W9Status { get; set; }
        [DataMember]
        public string StatusTs { get; set; }

    }
}
