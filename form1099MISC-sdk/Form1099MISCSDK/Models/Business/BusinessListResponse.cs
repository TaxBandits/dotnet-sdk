using Form1099MISCSDK.Models.Base;
using System.Runtime.Serialization;

namespace Form1099MISCSDK.Models.Business
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
