using BusinessApiSDK.Models.Base;
using BusinessApiSDK.Models.Business;
using BusinessApiSDK.Models.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Xml;
using Constants = BusinessApiSDK.Models.Utilities.Constants;
using Formatting = Newtonsoft.Json.Formatting;

namespace BusinessApiSDK.Controllers
{
    public class BusinessController : Controller
    {
        #region Business View Page
        [HttpGet]
        public IActionResult CreateBusiness()
        {

            return View();
        }
        #endregion

        #region Business Create 

        [HttpPost]
        public ActionResult CreateBusiness(BusinessCreateRequest createBusiness)
        {
            var responseJson = string.Empty;
            var businessCreateResponse = new BusinessCreateResponse();

            // Generate JSON for Business
            var requestJson = JsonConvert.SerializeObject(createBusiness, Formatting.Indented);

            //Get Access token from OAuth API response 
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            string generatedAccessToken = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(generatedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Business Create
                    string requestUri = Constants.CREATE_BUSINESS;
                    //Get APIUrl From Appsetting 
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedAccessToken);
                    //Create Response from API
                    var apiResponse = apiClient.PostAsJsonAsync(requestUri, createBusiness).Result;

                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response 
                        var createResponse = apiResponse.Content.ReadAsAsync<BusinessCreateResponse>().Result;
                        if (createResponse != null)
                        {
                            responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to BusinessCreateResponse object
                            businessCreateResponse = JsonConvert.DeserializeObject<BusinessCreateResponse>(responseJson);
                        }
                    }
                    else
                    {
                        var createResponse = apiResponse.Content.ReadAsAsync<Object>().Result;
                        responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);

                        //Deserializing JSON (Error Response) to BusinessCreateResponse object
                        businessCreateResponse = JsonConvert.DeserializeObject<BusinessCreateResponse>(responseJson);
                    }
                }
            }

            return PartialView("_BusinessCreateResponse", businessCreateResponse);

        }
        #endregion

        #region Get Business List
        [HttpGet]
        public ActionResult GetBusinessList()
        {
            var businessListResponse = new BusinessListResponse();
            var business = new List<Business>();
            var getResponseJSON = string.Empty;
           
            //Get Access token from GetAccessToken Class
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            //Get Access token from OAuth API response
            var generatedAccessToken = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(generatedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Get Business List Return
                    string requestUri = Constants.BUSINESS_LIST; 
                    //Get URLs from App.Config
                    apiClient.BaseAddress = new Uri(Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL));
                    //Construct HTTP headers
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedAccessToken);
                    //Get Business List Response from API
                    var _response = apiClient.GetAsync(requestUri).Result;

                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response from API
                        var listResponse = _response.Content.ReadAsAsync<BusinessListResponse>().Result;
                        if (listResponse != null)
                        {
                            getResponseJSON = JsonConvert.SerializeObject(listResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to businessListResponse object
                            businessListResponse = JsonConvert.DeserializeObject<BusinessListResponse>(getResponseJSON);
                            business = businessListResponse.Businesses;
                        }
                    }
                    

                }

            }
            return View("GetBusinessList", business);
        }
        #endregion

        #region Get BusinessDetail By BusinessId
        [HttpGet]
        public IActionResult GetBusinessDetail(Guid businessId)
        {
            var businessGetResponse = new BusinessGetResponse();
            var businessGetResponseJSON = string.Empty;

            if (businessId != Guid.Empty)
            {
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
                        //API URL to Get Business Return using BusinessId 
                        string requestUri = Constants.BUSINESS_GET + businessId;

                        apiClient.BaseAddress = new Uri(apiUrl);
                        //Construct HTTP headers
                        OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedAccessToken);
                        //Get Response
                        var _response = apiClient.GetAsync(requestUri).Result;

                        if (_response != null && _response.IsSuccessStatusCode)
                        {
                            //Read Response from API
                            var getResponse = _response.Content.ReadAsAsync<BusinessGetResponse>().Result;
                            if (getResponse != null)
                            {
                                businessGetResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                                businessGetResponse = JsonConvert.DeserializeObject<BusinessGetResponse>(businessGetResponseJSON);

                            }
                        }
                        else
                        {
                            //Read Response from API
                            var getResponse = _response.Content.ReadAsAsync<Object>().Result;
                            businessGetResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                            businessGetResponse = JsonConvert.DeserializeObject<BusinessGetResponse>(businessGetResponseJSON);
                        }

                    }
                }
            }

            return View("CreateBusiness", businessGetResponse.Business);
        }
        #endregion

        #region  Business Members Type  based on Business Type
        [HttpGet]
        public ActionResult BusinessMembersType(string selectedBusinessTypeVal)
        {
            var businessType = selectedBusinessTypeVal;
            if (!string.IsNullOrWhiteSpace(businessType))
            {
                var businessMembersList = new List<SelectListItem>();

                #region DropDownValues for Business MemberType

                if (businessType == BusinessType.ESTE.ToString())
                {
                    //Assign Values from EstateBusinessMembers Enum to te List
                    businessMembersList = Enum.GetValues(typeof(EstateBusinessMembers)).Cast<EstateBusinessMembers>().Select(x => new SelectListItem { Text = Utility.GetEnumDisplayName(x), Value = (x).ToString() }).ToList();
                }
                else if (businessType == BusinessType.PART.ToString())
                {
                    //Assign Values from PartnershipBusinessMembers Enum to te List
                    businessMembersList = Enum.GetValues(typeof(PartnershipBusinessMembers)).Cast<PartnershipBusinessMembers>().Select(x => new SelectListItem { Text = Utility.GetEnumDisplayName(x), Value = (x).ToString() }).ToList();
                }
                else if (businessType == BusinessType.CORP.ToString())
                {
                    //Assign Values from CorporationBusinessMembers Enum to te List
                    businessMembersList = Enum.GetValues(typeof(CorporationBusinessMembers)).Cast<CorporationBusinessMembers>().Select(x => new SelectListItem { Text = Utility.GetEnumDisplayName(x), Value = (x).ToString() }).ToList();
                }
                else if (businessType == BusinessType.EORG.ToString())
                {
                    //Assign Values from ExemptOrganizationBusinessMembers Enum to te List
                    businessMembersList = Enum.GetValues(typeof(ExemptOrganizationBusinessMembers)).Cast<ExemptOrganizationBusinessMembers>().Select(x => new SelectListItem { Text = Utility.GetEnumDisplayName(x), Value = (x).ToString() }).ToList();
                }
                else if (businessType == BusinessType.SPRO.ToString())
                {
                    //Assign Values from SoleProprietorshipBusinessMembers Enum to te List
                    businessMembersList = Enum.GetValues(typeof(SoleProprietorshipBusinessMembers)).Cast<SoleProprietorshipBusinessMembers>().Select(x => new SelectListItem { Text = Utility.GetEnumDisplayName(x), Value = (x).ToString() }).ToList();
                }
                return new JsonResult(new { data = businessMembersList });
                #endregion
            }
            return new JsonResult(false);
        }
        #endregion

        #region Business Update 

        [HttpPost]
        public ActionResult UpdateBusiness(BusinessUpdateRequest updateBusiness)
        {
            var responseJson = string.Empty;
            var businessupdateResponse = new BusinessUpdateResponse();

            string apiUrl = Utility.GetAppSettings(Constants.TBS_PUBLIC_API_BASE_URL);
            // Generate JSON for Business
            var requestJson = JsonConvert.SerializeObject(updateBusiness, Formatting.Indented);
            //Get Access token from OAuth API response 
            GetAccessToken accessToken = new GetAccessToken(HttpContext);
            string generatedAccessToken = accessToken.GetGeneratedAccessToken();

            if (!string.IsNullOrWhiteSpace(generatedAccessToken))
            {
                using (var apiClient = new HttpClient())
                {
                    //API URL to Business Update
                    string requestUri = Constants.BUSINESS_UPDATE;
                    apiClient.BaseAddress = new Uri(apiUrl);
                    //Construct HTTP headers in Generated Token.
                    OAuthGenerator.ConstructHeadersWithAccessToken(apiClient, generatedAccessToken);
                    //Put Response from API
                    var apiResponse = apiClient.PutAsJsonAsync(requestUri, updateBusiness).Result;
                    if (apiResponse != null && apiResponse.IsSuccessStatusCode)
                    {
                        //Read Response
                        var updateResponse = apiResponse.Content.ReadAsAsync<BusinessUpdateResponse>().Result;
                        if (updateResponse != null)
                        {
                            responseJson = JsonConvert.SerializeObject(updateResponse, Formatting.Indented);
                            //Deserializing JSON (Success Response) to businessupdateResponse object
                            businessupdateResponse = JsonConvert.DeserializeObject<BusinessUpdateResponse>(responseJson);
                        }
                    }
                    else
                    {
                        var updateResponse = apiResponse.Content.ReadAsAsync<Object>().Result;
                        responseJson = JsonConvert.SerializeObject(updateResponse, Formatting.Indented);

                        //Deserializing JSON (Error Response) to businessupdateResponse object
                        businessupdateResponse = JsonConvert.DeserializeObject<BusinessUpdateResponse>(responseJson);
                    }
                }
            }

            return PartialView("_BusinessUpdateResponse", businessupdateResponse);

        }
        #endregion
    }
}
