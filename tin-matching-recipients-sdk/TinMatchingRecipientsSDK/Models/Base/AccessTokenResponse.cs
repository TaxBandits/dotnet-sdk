namespace TinMatchingRecipientsSDK.Models.Base
{
    public class AccessTokenResponse
    {

        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public int ExpiresIn { get; set; }

        public List<Error> Errors { get; set; }

        /// <summary>
        /// It will return the name of status code.
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// It will return the Status Name
        /// </summary>
        public string StatusName { get; set; }
        /// <summary>
        /// It will return the detailed message of status code.
        /// </summary>SS
        public string StatusMessage { get; set; }
    }
}
