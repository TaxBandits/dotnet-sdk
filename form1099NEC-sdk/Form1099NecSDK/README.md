# Using the Form1099NEC API with C#
Form1099NEC SDK written on C# in .Net Core framework(Version 6.0) to show how to integrate with TaxBandits Form1099Nec API. This covers the following API Methods.
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
- Run the Form1099NECSDK application provided for sandbox testing.
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
5. For the AWS Key, please refer https://developer.taxbandits.com/docs/Form1099NEC/requestdraftpdfurl#decrypt-pdf-urls. Once you got the AWS Key, replace those under appsettings.
6. Run the sample Form1099NEC application provided for sandbox testing.

## Endpoints Used
The below endpoints are used in this SDK,
### Business
- Create 
- List
### Form1099NEC
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

## Validate Form Form1099-NEC
<<<<<<< HEAD
It checks the request's 1099-NEC Forms to IRS business standards and field specifications before creating Form1099NEC. For validating Form1099NEC, pass the recipient and Form1099NEC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).StateRecon is allowed for WestVirginia and Alabama State.  After requesting validateForm method in Form1099NEC API, the response will be shown in a modal.
 
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/ValidateForm]
## Create Form1099-NEC
For creating Form1099-NEC, pass the recipient and Form1099NEC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId. StateRecon is allowed for WestVirginia and Alabama State. After requesting create method in Form1099NEC API, the response will be shown in a modal.
=======
It checks the request's 1099-NEC Forms to IRS business standards and field specifications before creating Form1099NEC. For validating Form1099NEC, pass the recipient and Form1099NEC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). After requesting validateForm method in Form1099NEC API, the response will be shown in a modal.StateRecon is allowed for WestVirginia and Alabama State. 

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/ValidateForm]
## Create Form1099-NEC
For creating Form1099-NEC, pass the recipient and Form1099NEC data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId. After requesting create method in Form1099NEC API, the response will be shown in a modal.
>>>>>>> 3f145c9109632e8d06931ba79cd36ee96d2acf13

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/Create]
## List Form1099-NEC
For listing Form1099-NEC, BusinessId is passed as query parameter along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).
After requesting list method in Form1099-NEC, the response is shown as a table.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/List]
## Update Form1099-NEC
For updating Form1099-NEC we are requesting get Form1099-NEC method from Form1099NEC API and fetch the data against SubmissionId and RecordId which is passed as query. After retrieving data we'll update it by requesting TBS Public API Base URL.
After requesting update method in Form1099NEC API, output will be shown in a modal and navigated to listForm1099NEC page. StateRecon is allowed for WestVirginia and Alabama State.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/Update]
## Form1099-NEC Status
For displaying Form1099-NEC Status, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). 
After requesting status method in Form1099NEC API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/Status]
## Delete Form1099-NEC 
For deleting TIN Matching Recipients, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Delete method in Form1099NEC API shows success response only if requested Form1099NEC is in not transmitted status else it will show error response. By passing these values we request to TBS Public API Base URL. 
After requesting delete method in Form1099NEC API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/Delete]
## Transmit Form1099-NEC 
For transmitting Form1099-NEC, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Transmit method in Form1099NEC API shows error response for already transmitted forms. By passing these values we request to TBS Public API Base URL. 
After requesting transmit method in Form1099NEC API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/Transmit]
## RequestDraftPdfUrl Form1099-NEC 
For requestingDraftPdfUrl of Form1099-NEC, pass the RecordId as request body along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). requestDraftPdfUrl method in Form1099NEC API shows success response only for not transmitted forms else it shows error response. By passing these values we request to TBS Public API Base URL. 
After requesting requstingDraftPdfUrl method in Form1099NEC API, the response pdf url will be decrypted and pdf is shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/RequestDraftPdfUrl]
## RequestPdfUrls Form1099-NEC 
For requestingPdfUrl of Form1099-NEC, pass the SubmissionId and RecordId as request body along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). requestPdfUrl method in Form1099NEC API shows success response only for transmitted forms else it shows error response. By passing these values we request to TBS Public API Base URL. 
After requesting requestPdfUrl method in Form1099NEC API, the response pdf urls will be shown in a table and by choosing anyone url ,it will be decrypted and shown as pdf in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form1099NEC/RequestPdfURLs]

In the above URLs, {version} is the endpoint version of TaxBandits API. Likely, v1.6.1, v1.7.0, v1.7.1 or v1.7.3.
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