using System.IdentityModel.Tokens.Jwt;
using TinMatchingRecipientsSDK.Models.Base;

namespace TinMatchingRecipientsSDK.Models.Utilities
{
    public class GetAccessToken
    {
        private ISession Session;
        public GetAccessToken(HttpContext HttpContext)
        {
            Session = HttpContext.Session;
        }

        #region Get Generated Access Token
        public string GetGeneratedAccessToken()
        {
            var GeneratedAccesToken = string.Empty;

            //Checking whether session having access token or not
            if (Session != null && Session.GetString("sessionToken") != null)
            {
                //if the sessison having the accestoken, then check whethere it is expired or not
                bool isJWTExpired = CheckIsJWTExpired(Session.GetString("sessionToken"));

                if (isJWTExpired)
                {
                    //If it is expired, Calling AccessTokenGenerator to regenerate it.
                    GeneratedAccesToken = AccessTokenGenerator();
                }
                else
                {
                    //if it not, getting the access token from session.
                    GeneratedAccesToken = Session.GetString("sessionToken");
                }
            }
            else
            {
                //If session is null, then calling accesstokengenerator.
                GeneratedAccesToken = AccessTokenGenerator();
            }

            return GeneratedAccesToken;
        }
        #endregion

        #region Access Token Generation
        public string AccessTokenGenerator()
        {

            var jwt = string.Empty;
            var response = new HttpResponseMessage();
            //Get URLs from App.Config
            string oAuthApiUrl = Utility.GetAppSettings(Constants.OAUTH_API_URL);

            using (var oAuthClient = new HttpClient())
            {
                oAuthClient.BaseAddress = new Uri(oAuthApiUrl);
                //Generate JWS and get access token (JWT)
                OAuthGenerator.GenerateJWSAndGetAccessToken(oAuthClient);
                //Read OAuth API response
                response = oAuthClient.GetAsync(oAuthApiUrl).Result;

                if (response != null && response.IsSuccessStatusCode)
                {
                    var oauthApiResponse = response.Content.ReadAsAsync<AccessTokenResponse>().Result;

                    if (oauthApiResponse != null && oauthApiResponse.StatusCode == 200)
                    {
                        //Get Access token from OAuth API response
                        //Access token is valid for one hour
                        jwt = oauthApiResponse.AccessToken;
                        //Set the JWT value in session variable 
                        Session.SetString("sessionToken", jwt);

                    }
                }

                return jwt;
            }

        }

        #endregion

        #region Checking JWT Expired Or Not
        public static bool CheckIsJWTExpired(string JWT)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = new JwtSecurityToken();
            token = tokenHandler.ReadJwtToken(JWT);
            bool isJWTExpired = false;
            if (token != null && token.Claims != null && token.Claims.Any())
            {
                if (token.Claims.Any(x => x.Type == JwtRegisteredClaimNames.Exp))
                {
                    int expiryTime = Utility.GetInt(token.Claims.First(claim => claim.Type == JwtRegisteredClaimNames.Exp).Value);

                    int currentTime = Utility.GetInt(OAuthGenerator.ConvertToUnixEpochString(DateTime.Now));

                    if (expiryTime < currentTime)
                    {
                        isJWTExpired = true;
                    }
                }
            }
            return isJWTExpired;

        }
        #endregion
    }
}
