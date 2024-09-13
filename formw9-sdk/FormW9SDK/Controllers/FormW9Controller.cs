using FormW9SDK.Models.Base;
using FormW9SDK.Models.Business;
using FormW9SDK.Models.FormW9;
using FormW9SDK.Models.Utilities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FormW9SDK.Controllers
{
    public class FormW9Controller : Controller
    {
        #region CreateForm W9 Request Email View
        public ActionResult CreateFormW9View(Guid businessId, string businessName, string tin)
        {
            if (businessId != Guid.Empty || !string.IsNullOrWhiteSpace(businessName) || !string.IsNullOrWhiteSpace(tin))
            {
                W9RequestByEmailRequest createRequest = new W9RequestByEmailRequest
                {
                    Requester = new BusinessRequestInfo { BusinessId = businessId,BusinessName= businessName ,TIN= tin } 
                };
                return View(createRequest);
            }
            return View();
        }
        #endregion

        #region Form w9 Create 
        [HttpPost]
        public ActionResult CreateFormW9(W9RequestByEmailRequest createRequest)
        {
            var formW9CreateResponseJson = string.Empty;
            var formW9CreateResponse = new W9RequestByEmailResponse();
            //Get APIUrl From Appsetting 
            string ApiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            //Get Access token from OAuth API response 
            GetAccessToken AccessToken = new GetAccessToken(HttpContext);
            string GeneratedAccessToken = AccessToken.GetGeneratedAccessToken();
            if (!string.IsNullOrWhiteSpace(GeneratedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL for w9 Create
                    string requestUri = Constants.REQUEST_W9_EMAIL;
                    apiClient.BaseAddress = new Uri(ApiUrl);
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, GeneratedAccessToken);
                    //Post Response from Api
                    var apiResponse = apiClient.PostAsJsonAsync(requestUri, createRequest).Result;
                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response
                        var createResponse = apiResponse.Content.ReadAsAsync
                        <W9RequestByEmailResponse>
                        ().Result;
                        if (createResponse != null)
                        {
                            formW9CreateResponseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to formW9CreateResponse object
                            formW9CreateResponse = JsonConvert.DeserializeObject
                            <W9RequestByEmailResponse>
                            (formW9CreateResponseJson);
                        }
                    }
                    else
                    {
                        var createResponse = apiResponse.Content.ReadAsAsync
                        <W9RequestByEmailResponse>
                        ().Result;
                        formW9CreateResponseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                        //Deserializing JSON (Error Response) to formW9CreateResponse object
                        formW9CreateResponse = JsonConvert.DeserializeObject
                        <W9RequestByEmailResponse>
                        (formW9CreateResponseJson);
                    }
                }
            }
            return PartialView("_FormW9CreateResponse",formW9CreateResponse);
        }
        #endregion

        #region Form W9 List
        [HttpGet]
        public ActionResult GetFormW9List(Guid businessId)
        {
            var w9ListReturnResponse = new FormW9ListResponse();
            var w9GetReturnResponseJSON = string.Empty;
            //Get URLs from App.Config
            string apiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            //Get Access token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get Access token from OAuth API response
            var generatedAccessToken = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(generatedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get W9 List Return
                    string requestUri = Constants.REQUEST_W9_LIST + "?BusinessId=" + businessId + "&Page=1&PageSize=10";
                    apiClient.BaseAddress = new Uri(apiUrl);
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedAccessToken);
                    //Get Response
                    var apiResponse = apiClient.GetAsync(requestUri).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var listResponse = apiResponse.Content.ReadAsAsync<FormW9ListResponse>().Result;
                        if (listResponse != null)
                        {
                            w9GetReturnResponseJSON = JsonConvert.SerializeObject(listResponse, Formatting.Indented);
                            w9ListReturnResponse = JsonConvert.DeserializeObject<FormW9ListResponse>(w9GetReturnResponseJSON);
                        }
                    }
                    else
                    {
                        //Read Response from API
                        var listResponse = apiResponse.Content.ReadAsAsync<FormW9ListResponse>().Result;
                        w9GetReturnResponseJSON = JsonConvert.SerializeObject(listResponse, Formatting.Indented);
                        w9ListReturnResponse = JsonConvert.DeserializeObject<FormW9ListResponse>(w9GetReturnResponseJSON);
                       
                    }
                }
            }

            return View("GetFormW9List", w9ListReturnResponse);
        }
        #endregion

        #region Get W9 Status 
        [HttpGet]
        public IActionResult GetStatus(string payeeRef, Guid businessId)
        {
            var w9StatusResponse = new W9StatusResponse();
            var w9StatusResponseJSON = string.Empty;
            //Get  token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get Access token from OAuth API response
            var jwt = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(jwt))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get Status using SubmissionId and RecordId 
                    string requestUrl = Constants.REQUEST_W9_STATUS + "?PayeeRef=" + payeeRef + "&BusinessId=" + businessId;
                    //Get URLs from App.Config
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, jwt);
                    //Get Status Response
                    var apiResponse = apiClient.GetAsync(requestUrl).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var getStatusResponse = apiResponse.Content.ReadAsAsync<W9StatusResponse>().Result;
                        w9StatusResponseJSON = JsonConvert.SerializeObject(getStatusResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to w9StatusResponse object
                        w9StatusResponse = JsonConvert.DeserializeObject<W9StatusResponse>(w9StatusResponseJSON);
                    }
                    else
                    {
                        //Read Response from API
                        var getStatusResponse = apiResponse.Content.ReadAsAsync<Object>().Result;
                        w9StatusResponseJSON = JsonConvert.SerializeObject(getStatusResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to w9StatusResponse object
                        w9StatusResponse = JsonConvert.DeserializeObject<W9StatusResponse>(w9StatusResponseJSON);
                    }
                }
            }

            return PartialView("_W9StatusResponse", w9StatusResponse);
        }
        #endregion

        #region Form W9 Delete 
        [HttpGet]
        public ActionResult Delete(string submissionId)
        {
            var W9DeleteResponseJson = string.Empty;
            var w9DeleteResponse = new W9CommonDeleteResponse();
            //Get APIUrl From Appsetting 
            string ApiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            //Get Access token from OAuth API response 
            GetAccessToken AccessToken = new GetAccessToken(HttpContext);
            string GeneratedAccessToken = AccessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(GeneratedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL for FormW9 Delete
                    string requestUri = Constants.REQUEST_W9_DELETE + "?SubmissionId=" + submissionId;
                    apiClient.BaseAddress = new Uri(ApiUrl);
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, GeneratedAccessToken);
                    //Post Response
                    var apiResponse = apiClient.DeleteAsync(requestUri).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response
                        var apiDeleteResponse = apiResponse.Content.ReadAsAsync<W9CommonDeleteResponse>().Result;
                        W9DeleteResponseJson = JsonConvert.SerializeObject(apiDeleteResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to w9DeleteResponse object
                        w9DeleteResponse = JsonConvert.DeserializeObject<W9CommonDeleteResponse>(W9DeleteResponseJson);
                    }
                    else
                    {
                        var apiDeleteResponse = apiResponse.Content.ReadAsAsync<W9CommonDeleteResponse>().Result;
                        W9DeleteResponseJson = JsonConvert.SerializeObject(apiDeleteResponse, Formatting.Indented);
                        //Deserializing JSON (Error Response) to w9DeleteResponse object
                        w9DeleteResponse = JsonConvert.DeserializeObject<W9CommonDeleteResponse>(W9DeleteResponseJson);
                    }
                }
            }

            return PartialView("_W9DeleteResponse", w9DeleteResponse);
        }
        #endregion

        #region Form W9 GetPdf 
        [HttpGet]
        public ActionResult Get(string payeeRef, Guid businessId)
        {
            var formW9GetPdfResponseJson = string.Empty;
            var formW9GetPdfResponse = new FormW9GetResponse();

            //Get APIUrl From Appsetting 
            string ApiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            //Get Access token from OAuth API response 
            GetAccessToken AccessToken = new GetAccessToken(HttpContext);
            string GeneratedAccessToken = AccessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(GeneratedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to W9 GETPDF
                    string requestUri = Constants.REQUEST_W9_GETPDF + "?PayeeRef=" + payeeRef + "&BusinessId=" + businessId;
                    apiClient.BaseAddress = new Uri(ApiUrl);
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, GeneratedAccessToken);
                    //Post Response
                    var apiResponse = apiClient.GetAsync(requestUri).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response
                        var transmitResponse = apiResponse.Content.ReadAsAsync<FormW9GetResponse>().Result;
                        if (transmitResponse != null)
                        {
                            formW9GetPdfResponseJson = JsonConvert.SerializeObject(transmitResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to FormW9 object
                            formW9GetPdfResponse = JsonConvert.DeserializeObject<FormW9GetResponse>(formW9GetPdfResponseJson);
                        }
                    }
                    else
                    {
                        var transmitResponse = apiResponse.Content.ReadAsAsync<FormW9GetResponse>().Result;
                        formW9GetPdfResponseJson = JsonConvert.SerializeObject(transmitResponse, Formatting.Indented);
                        //Deserializing JSON (Error Response) to FormW9 object
                        formW9GetPdfResponse = JsonConvert.DeserializeObject<FormW9GetResponse>(formW9GetPdfResponseJson);
                    }
                }
            }

            return PartialView("_FormW9GetResponse", formW9GetPdfResponse);
        }
        #endregion
    }
}
