using BusinessApiSDK.Models.Utilities;
using System.Runtime.Serialization;

namespace BusinessApiSDK.Models.Business
{
    [DataContract]
    public class BusinessGetResponse : BaseResponseStatus
    {
        /// <summary>
        /// Business Details
        /// </summary>
        [DataMember(Order = 1)]
        public Business Business { get; set; }

        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        [DataMember(Order = 2)]
        public List<Error> Errors { get; set; }
    }
}
