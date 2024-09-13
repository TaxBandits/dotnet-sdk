using BusinessApiSDK.Models.Utilities;
using System.Runtime.Serialization;

namespace BusinessApiSDK.Models.Business
{
    [DataContract]
    public class BusinessUpdateResponse: BaseResponseStatus
    {
        /// <summary>
        /// Business Identifier
        /// </summary>
        [DataMember(Order = 1)]
        public Guid BusinessId { get; set; }

        [DataMember(Order = 2)]
        public string PayerRef { get; set; }

        [DataMember(Order = 3)]
        public bool IsEIN { get; set; }

        [DataMember(Order = 4)]
        public string EINorSSN { get; set; }

        [DataMember(Order = 5)]
        public string BusinessNm { get; set; }
        [DataMember(Order = 6)]
        public string FirstNm { get; set; }
        [DataMember(Order = 7)]
        public string LastNm { get; set; }
        [DataMember(Order = 8)]
        public string MiddleNm { get; set; }
        [DataMember(Order = 9)]
        public string Suffix { get; set; }

        [DataMember(Order = 10)]
        public List<Error> Errors { get; set; }
    
    }
}
