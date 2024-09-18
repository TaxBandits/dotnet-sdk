# Using the Form941 API with C#
Form941 SDK written on C# in .Net Core framework(Version 6.0) to show how to integrate with TaxBandits Form941 API. This covers the following API Methods.
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
- Run the Form941SDK application provided for sandbox testing.
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
5. Run the sample Form941 application provided for sandbox testing.

## Endpoints Used
The below endpoints are used in this SDK,
### Business
- Create 
- List
### Form941
- Create 
- Update
- List
- Get
- ValidateForm
- Status
- Delete
- Transmit
- GetPdf

## Validate Form941
It checks the request's 941 Forms to IRS business standards and field specifications before creating Form941. For validating Form941, pass the recipient and Form941 data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). After requesting validateForm method in Form941 API, the response will be shown in a modal.
**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Validate]

## Create Form941
For creating Form941, pass the recipient and Form941 data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API) against businessId. After requesting create method in Form941, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Create]

## List Form941
For listing Form941, BusinessId is passed as query parameter along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).
After requesting list method in Form941, the response is shown as a table.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/List]

## Update Form941
For updating Form941 we are requesting get Form941 method from Form941 API and fetch the data against SubmissionId and RecordId which is passed as query. After retrieving data we'll update it by requesting TBS Public API Base URL.

After requesting update method in Form941 API, output will be shown in a modal and navigated to list Form941 page.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Update]

## Form941 Status
For displaying Form941 Status, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). 
After requesting status method in Form941 API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Status]

## Delete Form941
For deleting TIN Matching Recipients, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Delete method in Form941 API shows success response only if requested Form941 is in not transmitted status else it will show error response. By passing these values we request to TBS Public API Base URL. 
After requesting delete method in Form941 API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Delete]

## Transmit Form941
For transmitting Form941, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Transmit method in Form941 API shows error response for already transmitted forms. By passing these values we request to TBS Public API Base URL. 
After requesting transmit method in Form941 API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Form941/Transmit]

## GetPdf Form941
For get Pdf of Form941, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). After requesting getPdf method in Form941 API, the response will be shown in a modal.

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