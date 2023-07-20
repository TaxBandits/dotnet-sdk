using Microsoft.IdentityModel.Tokens;
using OAuthApiSDK.Models.APICredentials;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;

namespace OAuthApiSDK.Models.Utilities
{
    public class OAuthGenerator
    {
        #region Generating JWS
        public string GenerateJWS(Credentials apiCredentials)
        {
            #region Generating JWS And Assigning to Request Header Authentication

            if (!string.IsNullOrWhiteSpace(apiCredentials.ClientId) && !string.IsNullOrWhiteSpace(apiCredentials.ClientSecret) && !string.IsNullOrWhiteSpace(apiCredentials.UserToken))
            {
                // Encode the JWS with clientSecret to create a signature
                var clientSecretSymmetricKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(apiCredentials.ClientSecret));
                var signingCredentials = new SigningCredentials(clientSecretSymmetricKey, SecurityAlgorithms.HmacSha256);

                // Create the required set of claims with appropriate values
                var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Iss, apiCredentials.ClientId),
            new Claim(JwtRegisteredClaimNames.Sub, apiCredentials.ClientId),
            new Claim(JwtRegisteredClaimNames.Aud, apiCredentials.UserToken),
            new Claim(JwtRegisteredClaimNames.Iat, ConvertToUnixEpochTimestamp(DateTime.Now)),
        };
                // Create a JWT security token with the provided claims and signing credentials
                var securityToken = new JwtSecurityToken(null, null, claims, expires: DateTime.Now.AddMinutes(5), signingCredentials: signingCredentials);

                // WriteToken method constructs & returns the JWS
                var jwsSignature = new JwtSecurityTokenHandler().WriteToken(securityToken);
                return jwsSignature;

            }
            #endregion

            #region Error Message For Empty Credentials
            else
            {
                throw new Exception("Please check the API credentials.");
            }
            #endregion
        }
        #endregion

        #region ConvertToUnixEpochTimestamp
        public static string ConvertToUnixEpochTimestamp(DateTime dateTime)
        {
            string unixEpoch = string.Empty;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            if (dateTime != null && dateTime != DateTime.MinValue)
            {
                //Unix Epoch time calculation
                TimeSpan diff = dateTime.ToUniversalTime() - origin;
                unixEpoch = Math.Floor(diff.TotalSeconds).ToString();
            }
            return unixEpoch;
        }
        #endregion
    }
}
