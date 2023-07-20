using OAuthApiSDK.Models.Utilities;
using System.Runtime.Serialization;

namespace OAuthApiSDK.Models.Business
{
    public class BusinessListResponse: BaseResponseStatus
    {

        /// <summary>
        /// Business Details of all the business
        /// </summary>
        [DataMember(Order = 3)]
        public List<Business> Businesses { get; set; }
        [DataMember(Order = 4)]
        public List<Error> Errors { get; set; }
    }
}
