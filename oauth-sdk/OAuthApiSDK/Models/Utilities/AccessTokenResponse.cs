using System.Runtime.Serialization;

namespace OAuthApiSDK.Models.Utilities
{
    public class AccessTokenResponse : BaseResponseStatus
    {

        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public List<Error> Errors { get; set; }
    }
    public class Error
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
    public class BaseResponseStatus
    {

        /// <summary>
        /// It will return the status codes like 200, 300, etc., Refer Status Codes.
        /// </summary>
        [DataMember(Order = 1)]
        public int StatusCode { get; set; }
        /// <summary>
        /// It will return the name of status code.
        /// </summary>
        [DataMember(Order = 2)]
        public string StatusName { get; set; }
        /// <summary>
        /// It will return the detailed message of status code.
        /// </summary>
        [DataMember(Order = 3)]
        public string StatusMessage { get; set; }

    }
}
