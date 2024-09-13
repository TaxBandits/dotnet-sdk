using Form1099KSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099KSDK.Models.Business
{
    public class BusinessListResponse : BaseResponseStatus
    {
        /// <summary>
        /// Business Details of all the business
        /// </summary>
        [DataMember(Order = 1)]
        public List<Business> Businesses { get; set; }
        public List<Error> Errors { get; set; }
    }
}
