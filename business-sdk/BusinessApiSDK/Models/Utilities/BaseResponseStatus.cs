using System.Runtime.Serialization;

namespace BusinessApiSDK.Models.Utilities
{
    [DataContract]
    public class BaseResponseStatus
    {
        /// <summary>
        /// It will return the status codes like 200, 300, etc., Refer Status Codes.
        /// </summary>
        [DataMember]
        public int StatusCode { get; set; }

        /// <summary>
        /// It will return the name of status code.
        /// </summary>
        [DataMember]
      
        public string StatusName { get; set; }

        /// <summary>
        /// It will return the detailed message of status code.
        /// </summary>
        [DataMember]
     
        public string StatusMessage { get; set; }
    }
}
