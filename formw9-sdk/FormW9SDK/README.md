# Using the FormW9 API with C#
FormW9 SDK written on C# in .Net Core framework(Version 6.0) to show how to integrate with TaxBandits FormW9 API. This covers the following API Methods.
### To get the Sandbox API keys:
- Go to Sandbox Developer console site: https://sandbox.taxbandits.com
- Signup or signin to Sandbox Developer console site
- Navigate to **settings** from the left menu and choose **API Credentials**. Copy client id, client secret and user token. 
### The sandbox URLs: (Please make sure to use the right versions)
- Sandbox Auth Server: https://testoauth.expressauth.net/v2/tbsauth 
- API URL: https://testapi.taxbandits.com/
## Cloning and Running the Application in local
- Clone the project into your local machine 
```bash
https://github.com/TaxBandits/tbs-dotnet-sdk.git
```
- Let's Navigate into the tin-matching-recipients-sdk folder.
- Run the FormW9 application provided for sandbox testing.
### Packages need to install
- To install Packages, right-click on your project in the Solution Explorer window and select **Manage NuGet packages**. Then, in the NuGet Package Manager window, search for required pacakges and install it.  
- System.IdentityModel.Tokens.Jwt:
	- This package for creating, serializing and validating JSON Web Tokens.
- Microsoft.AspNet.WebApi.Client:
	- This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.
- AWSSDK.S3:
	- Amazon Simple Storage Service (Amazon S3), provides secure, durable, highly-scalable object storage.  
### How to use?
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Open appsettings.json file and replace with your Client Id, Client Secret and User Token under appsettings tag.
5. Run the sample FormW9 application provided for sandbox testing.

## Endpoints Used
The below endpoints are used in this SDK,
### Business
- Create 
- List
### FormW9
- RequestByEmail 
- RequestByUrl
- List
- Get
- Status
- Delete

## RequestByUrl FormW9
To complete the Form W-9, TaxBandits will supply the URL that can be opened on an Iframe into a RequestByURl page.To get the URL, send a request to RequestByUrl method in FormW9 API  with a unique Payee Reference along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId. In case error response, it will be shown in modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/FormW9/RequestByUrl]

## RequestByEmail FormW9
This endpoint sends a unique url via email to the recipients to complete their form W-9. The endpoint needs the name and the recipient’s email address along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId to generate the unique url . The recipients will receive an email with the link to complete their Form W-9 in a secured portal. Once the recipients complete the Form W-9, status will be updated in listFormW9 page. After requesting RequestByEmail method in FormW9 API, the response will be shown in a modal. In case of success response, it will be navigated to ListFormW9 page.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/FormW9/RequestByEmail]

## List FormW9
For listing Form W-9, BusinessId, TIN, Page, PageSize is passed as query parameter along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).
After requesting list method in FormW-9, the response is shown as a table.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/FormW9/List]

In the above URLs, {version} is the endpoint version of TaxBandits API. Likely,  v1.7.0, v1.7.1 or v1.7.3.
### Project Folder Structure
* controllers:
	- The users input data are parsed and request models are constructed here.
	- All API response validations are also done here.
	- UI rendering logics (example, the dropdown values and default value mappings) are also included in the controllers. 
* models:
	- This folder contains the request and response models.
* Views:
	- All our view pages (.cshtml) are placed under this folder. 
* appsettings.json:
	- The appsettings.json file is an application configuration file used to add custom keys.
* wwwroot:
	- The wwwroot folder is a default folder in the ASP.NET Core project is treated as a web root folder. 
	- Static files can be stored in any folder under the web root and accessed with a relative path to that root.
* Program.cs:
	- A console file which starts executing from the entry point public static void Main() in Program class where we can create a host for the web application.
* Startup.cs:
	- A class file, it is like Global.asax in the traditional .NET application and it is executed first when the application starts.

For more information, please refer: https://developer.taxbandits.com/