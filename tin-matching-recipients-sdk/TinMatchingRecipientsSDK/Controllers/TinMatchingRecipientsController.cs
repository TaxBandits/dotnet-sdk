using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using TinMatchingRecipientsSDK.Models.Base;
using TinMatchingRecipientsSDK.Models.Business;
using TinMatchingRecipientsSDK.Models.TinMatchingRequest;
using TinMatchingRecipientsSDK.Models.TinMatchingResponse;
using TinMatchingRecipientsSDK.Models.Utilities;

namespace TinMatchingRecipientsSDK.Controllers
{
   public class TinMatchingRecipientsController : Controller
    {
        #region TIN Matching Request View
        [HttpGet]
        public ActionResult TinMatchingRequest(Guid? businessId, string tin, string businessName)
        {
            if (businessId != Guid.Empty && businessId != null && !string.IsNullOrWhiteSpace(tin) && !string.IsNullOrWhiteSpace(businessName))
            {
                TinMatchingRecipientsCreateRequest tinMatchingRequest = new TinMatchingRecipientsCreateRequest { TINMatchingDetails = new TINMatchingCreateRecipient { Business = new TINMatchingBusiness { BusinessId = businessId, TIN = tin, BusinessNm = businessName } } };

                return View(tinMatchingRequest);
            }

            return View();
        }
        #endregion

        #region TIN Matching Request for Recipients
        [HttpPost]
        public ActionResult TinMatchingRequest(TinMatchingRecipientsCreateRequest tinMatchingRequest)
        {
            var responseJson = string.Empty;
            var tinMatchingResponse = new TinMatchingRecipientsCreateResponse();

            //Get  token from OAuth API response 
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            string generatedJwt = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(generatedJwt))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL for Request Method
                    string requestUri = Constants.REQUEST_TINMATCHING_URL;
                    //Get APIUrl From Appsetting 
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedJwt);
                    //Request method Response from API
                    var apiResponse = apiClient.PostAsJsonAsync(requestUri, tinMatchingRequest).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response 
                        var tinMatchingRequestResponse = apiResponse.Content.ReadAsAsync<TinMatchingRecipientsCreateResponse>().Result;
                        if (tinMatchingRequestResponse != null)
                        {
                            responseJson = JsonConvert.SerializeObject(tinMatchingRequestResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to tinMatchingResponse object
                            tinMatchingResponse = JsonConvert.DeserializeObject<TinMatchingRecipientsCreateResponse>(responseJson);
                        }
                    }
                    else
                    {
                        var tinMatchingRequestResponse = apiResponse.Content.ReadAsAsync<Object>().Result;
                        responseJson = JsonConvert.SerializeObject(tinMatchingRequestResponse, Formatting.Indented);

                        //Deserializing JSON (Error Response) to tinMatchingResponse object
                        tinMatchingResponse = JsonConvert.DeserializeObject<TinMatchingRecipientsCreateResponse>(responseJson);
                    }
                }
            }

            return PartialView("_RequestResponse", tinMatchingResponse);
        }
        #endregion

        #region TIN Matching List for Recipients
        [HttpGet]
        public ActionResult TinMatchingList(Guid? businessId, string tin, string businessName)
        {
            var tinMatchingListResponse = new TinMatchingListResponse();
            var listResponseJSON = string.Empty;
            var tinMatchingRecords = new List<TINMatchingRecords>();
            //Get  token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get  token from OAuth API response
            var jwt = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(jwt))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get TinMatching List 
                    string requestUri = Constants.TINMATCHING_LIST_URL + "?BusinessId=" + businessId;
                    //Get URLs from App.Config
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, jwt);
                    //Get TinMatching List Response from API
                    var _response = apiClient.GetAsync(requestUri).Result;

                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var listResponse = _response.Content.ReadAsAsync<TinMatchingListResponse>().Result;
                        if (listResponse != null)
                        {
                            listResponseJSON = JsonConvert.SerializeObject(listResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to tinMatchingListResponse object
                            tinMatchingListResponse = JsonConvert.DeserializeObject<TinMatchingListResponse>(listResponseJSON);
                            tinMatchingRecords = tinMatchingListResponse.TINMatchingRecords;

                        }
                    }
                    else
                    {
                        var listResponse = _response.Content.ReadAsAsync<Object>().Result;
                        listResponseJSON = JsonConvert.SerializeObject(listResponse, Formatting.Indented);

                        //Deserializing JSON (Error Response) to tinMatchingResponse object
                        tinMatchingListResponse = JsonConvert.DeserializeObject<TinMatchingListResponse>(listResponseJSON);
                        tinMatchingListResponse.Business = new TINMatchingBusiness();
                        tinMatchingListResponse.Business.BusinessId = Utility.GetGuid(businessId);
                        tinMatchingListResponse.Business.TIN = tin;
                        tinMatchingListResponse.Business.BusinessNm = businessName;

                    }
                }
            }

            return PartialView("TinMatchingRecipientsList", tinMatchingListResponse);
        }
        #endregion

        #region Get TinMatching Status 
        [HttpGet]
        public IActionResult GetTinMtachingStatus(Guid submissionId, Guid recordId)
        {
            var statusResponse = new TinMatchingGetStatusResponse();
            var statusResponseJSON = string.Empty;
            //Get  token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get Access token from OAuth API response
            var jwt = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(jwt))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get Status using SubmissionId and RecordId 
                    string requestUrl = Constants.TINMATCHING_STATUS_URL + "?SubmissionId=" + submissionId + "&RecordId=" + recordId;
                    //Get URLs from App.Config
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, jwt);
                    //Get Status Response
                    var _response = apiClient.GetAsync(requestUrl).Result;

                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var getResponse = _response.Content.ReadAsAsync<TinMatchingGetStatusResponse>().Result;
                        if (getResponse != null)
                        {
                            statusResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to statusResponse object
                            statusResponse = JsonConvert.DeserializeObject<TinMatchingGetStatusResponse>(statusResponseJSON);
                        }
                    }
                    else
                    {
                        //Read Response from API
                        var getResponse = _response.Content.ReadAsAsync<Object>().Result;
                        statusResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to statusResponse object
                        statusResponse = JsonConvert.DeserializeObject<TinMatchingGetStatusResponse>(statusResponseJSON);
                    }
                }
            }

            return PartialView("_TinMatchingStatusView", statusResponse);
        }
        #endregion

        #region Cancel TinMatching  
        [HttpGet]
        public IActionResult CancelTinMatching(Guid submissionId, Guid recordId)
        {
            var cancelResponse = new TinMatchingCancelResponse();
            var cancelResponseJSON = string.Empty;

            //Get token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get token from OAuth API response
            var jwt = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(jwt))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Cancel Return using SubmissionId and RecordId 
                    string requestUrl = Constants.TINMATCHING_CANCEL_URL + "?SubmissionId=" + submissionId + "&RecordIds=" + recordId;
                    //Get URLs from App.Config
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, jwt);
                    //Get Response from API
                    var _response = apiClient.PutAsync(requestUrl, null).Result;

                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var tinMtachingCancelResponse = _response.Content.ReadAsAsync<TinMatchingCancelResponse>().Result;
                        if (tinMtachingCancelResponse != null)
                        {
                            cancelResponseJSON = JsonConvert.SerializeObject(tinMtachingCancelResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to cancelResponse object
                            cancelResponse = JsonConvert.DeserializeObject<TinMatchingCancelResponse>(cancelResponseJSON);
                        }
                    }
                    else
                    {
                        //Read Response from API
                        var tinMtachingCancelResponse = _response.Content.ReadAsAsync<Object>().Result;
                        cancelResponseJSON = JsonConvert.SerializeObject(tinMtachingCancelResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to cancelResponse object
                        cancelResponse = JsonConvert.DeserializeObject<TinMatchingCancelResponse>(cancelResponseJSON);
                    }
                }
            }

            return PartialView("_CancelResponse", cancelResponse);
        }
        #endregion
    }
}
