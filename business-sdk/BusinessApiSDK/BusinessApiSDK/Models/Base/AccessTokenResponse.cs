using BusinessApiSDK.Models.Business;
using BusinessApiSDK.Models.Utilities;
using System.Runtime.Serialization;

namespace BusinessApiSDK.Models.Base
{
    public class AccessTokenResponse
    {

        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public int ExpiresIn { get; set; }

        public List<Error> Errors { get; set; }

        public int StatusCode { get; set; }

        /// <summary>
        /// It will return the name of status code.
        /// </summary>
       

        public string StatusName { get; set; }

        /// <summary>
        /// It will return the detailed message of status code.
        /// </summary>
      

        public string StatusMessage { get; set; }
    }
}
