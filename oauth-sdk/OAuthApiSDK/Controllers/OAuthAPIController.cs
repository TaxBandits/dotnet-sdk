using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OAuthApiSDK.Models.APICredentials;
using OAuthApiSDK.Models.Business;
using OAuthApiSDK.Models.Utilities;
using Constants = OAuthApiSDK.Models.Utilities.Constants;

namespace OAuthApiSDK.Controllers
{
    public class OAuthAPIController : Controller
    {
        #region OAuthToken View Page
        [HttpGet]
        public IActionResult OAuthToken()
        {
            return View();
        }
        #endregion

        #region GetSignature
        [HttpPost]
        public IActionResult GetJWS(Credentials apiCredentials)
        {
            OAuthGenerator authGenerator = new OAuthGenerator();

            // Generate JWS for Getting Access Token
            TempData["JWS"] = authGenerator.GenerateJWS(apiCredentials);

            return RedirectToAction("OAuthToken");
        }
        #endregion

        #region Get AccessToken By JWS
        [HttpGet]
        public IActionResult GetAccessToken(string jws)
        {
            var response = new HttpResponseMessage();

            // Get OAuth URL from appsettings
            string oAuthApiUrl = Utility.GetAppSettings(Constants.OAUTH_API_URL);

            #region Get Access Token from OAUTH API
            using (var oAuthClient = new HttpClient())
            {
                //Get BaseAddress from appsettings
                oAuthClient.BaseAddress = new Uri(oAuthApiUrl);

                oAuthClient.DefaultRequestHeaders.Clear();

                //Add the JWS constructed to the Authentication header
                oAuthClient.DefaultRequestHeaders.Add("Authentication", jws);

                // Send GET request to OAuth API
                response = oAuthClient.GetAsync(oAuthApiUrl).Result;

                if (response != null && response.IsSuccessStatusCode)
                {
                    // Read response from OAuth API
                    var oauthApiResponse = response.Content.ReadAsAsync<AccessTokenResponse>().Result;

                    if (oauthApiResponse != null && oauthApiResponse.StatusCode.Equals(200))
                    {
                        // Assign Access token from OAuth API response
                        TempData["JWT"] = oauthApiResponse.AccessToken;
                        TempData["JWS"] = jws;
                    }
                }
                else if (response != null)
                {
                    //Read the Error Response from API
                    var oauthApiResponse = response.Content.ReadAsAsync<AccessTokenResponse>().Result;
                    //Convert the Response as Json
                    var jsonValue = JsonConvert.SerializeObject(oauthApiResponse, Formatting.Indented);
                    TempData["OAuthErrorResponse"] = jsonValue;
                }

                return RedirectToAction("OAuthToken");
            }
            #endregion
        }


        #endregion

        #region Get List Business to Verify JWT
        [HttpPost]
        public ActionResult GetBusinessList(string accessToken)
        {
            var Business = new List<Business>();
            var getReturnResponseJSON = string.Empty;

            //Get URLs from App.Config
            string ApiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                #region Get Business List from Business Api
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get Business List Return
                    string requestUri = "Business/List?Page=0&PageSize=10";

                    apiClient.BaseAddress = new Uri(ApiUrl);
                    //Construct HTTP headers
                    apiClient.DefaultRequestHeaders.Clear();
                    apiClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    //Add the JWT along with Bearer keyword to the Authorization header
                    apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                    //Get Response
                    var _response = apiClient.GetAsync(requestUri).Result;
                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response from Business Api
                        var createResponse = _response.Content.ReadAsAsync<BusinessListResponse>().Result;
                        Business = createResponse.Businesses;
                    }
                    else if (_response != null)
                    {
                        //Read Response from Business Api
                        var createResponse = _response.Content.ReadAsAsync<BusinessListResponse>().Result;

                        //If StatusCode is NotFound then create business
                        if (createResponse != null && createResponse.StatusCode.Equals(404))
                        {
                            //Create New Business 
                            var returnStatusCode = CreateBusiness(accessToken);
                            if (returnStatusCode.Equals(200))
                            {
                                //Get the List Response
                                var _listresponse = apiClient.GetAsync(requestUri).Result;

                                if (_listresponse != null && _listresponse.IsSuccessStatusCode)
                                {
                                    //Read Response from Business Api
                                    var listResponse = _listresponse.Content.ReadAsAsync<BusinessListResponse>().Result;
                                    Business = listResponse.Businesses;
                                }
                            }
                        }
                        else
                        {
                            //Convert the Response as Json
                            var jsonValue = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                            TempData["BusinessListError"] = jsonValue;
                        }

                        
                       
                    }
                }
                #endregion
            }
            return PartialView(Business);
        }
        #endregion

        #region Business Create 
        public int CreateBusiness(string accessToken)
        {
            #region Default Create Business Json
            var FormBusiness = new BusinessCreateRequest
            {
                BusinessId = null,
                BusinessNm = "Test Business",
                EINorSSN = "493588930",
                IsEIN = true,
                BusinessType = "ESTE",
                ContactNm = "John Doe",
                Email = "employer@company.com",
                Fax = "1234567890",
                TradeNm = "Kodak",
                IsBusinessTerminated = false,
                Phone = "1234566890",
                PhoneExtn = "12345",
                IsForeign = false,
                USAddress = new USAddress
                {
                    Address1 = "Address Line 1",
                    City = "Rockhill",
                    State = "SC",
                    ZipCd = "29730"
                },
                SigningAuthority = new SigningAuthority
                {
                    BusinessMemberType = "ADMINISTRATOR",
                    Phone = "1234564390",
                    Name = "John"
                },
                KindOfEmployer = "FEDERALGOVT",
                KindOfPayer = "REGULAR941",
                ForeignAddress = null,
            };
            #endregion

            //Get APIURL from Appsettings
            string ApiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);

            var listResponse = new BusinessListResponse();

            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                #region Create Business For New User
                using (var apiClient = new HttpClient())
                {
                    //API URL to Business Create
                    string requestUri = "Business/Create";
                    apiClient.BaseAddress = new Uri(ApiUrl);
                    //Construct HTTP headers
                    apiClient.DefaultRequestHeaders.Clear();
                    apiClient.DefaultRequestHeaders.Add("Accept", "application/json");
                    //Add the JWT along with Bearer keyword to the Authorization header
                    apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                    //Post Response
                    var apiResponse = apiClient.PostAsJsonAsync(requestUri, FormBusiness).Result;
                    //Read the Return Response
                    listResponse = apiResponse.Content.ReadAsAsync<BusinessListResponse>().Result;
                }
                #endregion
            }

            return listResponse.StatusCode;

        }
        #endregion
    }
}
