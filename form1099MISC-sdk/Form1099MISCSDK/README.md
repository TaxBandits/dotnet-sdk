# Using the Form1099MISC API with C#
Form1099MISC SDK written on C# in .Net Core framework(Version 6.0) to show how to integrate with TaxBandits Form1099MISC API. This covers the following API Methods.
### To get the sandbox keys:
- Go to Sandbox Developer console: https://sandbox.taxbandits.com
- Signup or signin to Sandbox 
- Navigate to **settings** from the left menu and choose **API Credentials**. Copy client id, client secret and user token. 
### The sandbox URLs: (Please make sure to use the right versions)
- Sandbox Auth Server: https://testoauth.expressauth.net/v2/tbsauth 
- API URL: https://testapi.taxbandits.com/
## Cloning and Running the Application in local
- Clone the project into your local machine https://github.com/TaxBandits/tbs-dotnet-sdk.git.
- Let's Navigate into the tin-matching-recipients-sdk folder.
- Run the TinMatchingRecipientsSDK application provided for sandbox testing.
### Packages need to install
To install Packages, right-click on your project in the Solution Explorer window and select “Manage NuGet packages…”. Then, in the NuGet Package Manager window, search for required pacakges and install it.  
* System.IdentityModel.Tokens.Jwt:
- This package for creating, serializing and validating JSON Web Tokens.
* Microsoft.AspNet.WebApi.Client:
- This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.
* AWSSDK.S3:
- Amazon Simple Storage Service (Amazon S3), provides secure, durable, highly-scalable object storage.  
### How to use?
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Open appsettings.json file and replace with your Client Id, Client Secret and User Token under appsettings tag.
5. Run the sample Form1099MISC application provided for sandbox testing.
### Business
- Create 
- List
### Form1099MISC
- Create 
- Update
- List
- Get
- ValidateForm
- Status
- Delete
- Transmit
- RequestPdfUrls
- RequestDraftPdfUrl
## Validate Form Form1099-MISC
It checks the request's 1099-MISC Forms to IRS business standards and field specifications before creating Form1099MISC. For validating Form1099MISC, pass the recipient and Form1099MISC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). After requesting validateForm method in Form1099MISC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/ValidateForm]
## Create Form1099-MISC
For creating Form1099-MISC, pass the recipient and Form1099MISC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId. After requesting create method in Form1099MISC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/Create]
## List Form1099-MISC
For listing Form1099-MISC, BusinessId is passed as query parameter along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).
After requesting list method in Form1099-MISC, the response is shown as a table.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/List]
## Update Form1099-MISC
For updating Form1099-MISC we are requesting get Form1099-MISC method from Form1099MISC API and fetch the data against SubmissionId and RecordId which is passed as query. After retrieving data we'll update it by requesting TBS Public API Base URL.
After requesting update method in Form1099MISC API, output will be shown in a modal and navigated to listForm1099MISC page.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/Update]
## Form1099-MISC Status
For displaying Form1099-MISC Status, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). 
After requesting status method in Form1099MISC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/Status]
## Delete Form1099-MISC 
For deleting TIN Matching Recipients, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Delete method in Form1099MISC API shows success response only if requested Form1099MISC is in not transmitted status else it will show error response. By passing these values we request to TBS Public API Base URL. 
After requesting delete method in Form1099MISC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/Delete]
## Transmit Form1099-MISC 
For transmitting Form1099-MISC, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Transmit method in Form1099MISC API shows error response for already transmitted forms. By passing these values we request to TBS Public API Base URL. 
After requesting transmit method in Form1099MISC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/Transmit]
## RequestDraftPdfUrl Form1099-MISC 
For requestingDraftPdfUrl of Form1099-MISC, pass the RecordId as request body along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). requestDraftPdfUrl method in Form1099MISC API shows success response only for not transmitted forms else it shows error response. By passing these values we request to TBS Public API Base URL. 
After requesting requstingDraftPdfUrl method in Form1099MISC API, the response pdf url will be decrypted and pdf is shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/RequestDraftPdfUrl]
## RequestPdfUrls Form1099-MISC 
For requestingPdfUrl of Form1099-MISC, pass the SubmissionId and RecordId as request body along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). requestPdfUrl method in Form1099MISC API shows success response only for transmitted forms else it shows error response. By passing these values we request to TBS Public API Base URL. 
After requesting requestPdfUrl method in Form1099MISC API, the response pdf urls will be shown in a table and by choosing anyone url ,it will be decrypted and shown as pdf in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099MISC/RequestPdfURLs]
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