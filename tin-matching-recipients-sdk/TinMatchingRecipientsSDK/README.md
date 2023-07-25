# Using the TinMatchingRecipients API with C#
TinMatchingRecipients API SDK written on C# in .Net Core framework(Version 6.0) to show how to integrate with TaxBandits TinMatchingRecipients API. 

## To get the sandbox keys:
- Go to Sandbox Developer console: https://sandbox.taxbandits.com
- Signup or signin to Sandbox 
- Navigate to **settings** from the left menu and choose **API Credentials**. Copy client id, client secret and user token. 

### The sandbox URLs: (Please make sure to use the right versions)
- Sandbox Auth Server: https://testoauth.expressauth.net/v2/tbsauth 
- API URL: https://testapi.taxbandits.com/

## Cloning and Running the Application in local
 - Clone the project into your local machine 
    ```bash
    git clone https://github.com/TaxBandits/tbs-dotnet-sdk.git
    ```
 - Let's Navigate into the tin-matching-recipients-sdk folder.
 - Run the TinMatchingRecipientsSDK application provided for sandbox testing.

## Packages need to install
To install Packages, right-click on your project in the Solution Explorer window and select �Manage NuGet packages��. Then, in the NuGet Package Manager window, search for required pacakges and install it.  
  
* System.IdentityModel.Tokens.Jwt:
    - This package for creating, serializing and validating JSON Web Tokens.
* Microsoft.AspNet.WebApi.Client
    - This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.

### How to use?
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Open appsettings.json file and replace with your Client Id, Client Secret and User Token under appsettings tag.
5. Run the sample TinMatchingRecipients application provided for sandbox testing.

### Business
- Create 
- List

### TinMatchingRecipients
- Request 
- List
- Status
- Cancel

## Request TIN Matching
For requesting TIN Matching, pass the recipient data as input along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). After requesting request method in TIN Matching Recipient API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/v1.7.3/TINMatchingRecipients/Request]

## List TIN Matching
For listing TIN Matching Recipients, BusinessId is passed as query parameter  along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API).
After requesting list method in TIN Matching Recipients, the reponse is shown as a table.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/v1.7.3/TINMatchingRecipients/List]
## TIN Matching Status
For displaying TIN Matching Recipients Status, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). 
After requesting status method in TIN Matching Recipients API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/v1.7.3/TINMatchingRecipients/Status]

## Cancel TIN Matching 
For canceling TIN Matching Recipients, pass the SubmissionId and RecordId as query along with Access Token in the header as Bearer Token (Generated using TaxBandits OAuth authentication API). Cancel method in TIN Matching Recipient API shows success response only if requested TIN Matching Recipient Status is in ORDER CREATED else it will show error response. By passing these values we request to TBS Public API Base URL. 
After requesting status method in TIN Matching Recipients API, the response will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/v1.7.3/TINMatchingRecipients/CancelRequest]
    
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
    
For more information, please refer: https://developer.taxbandits.com/
 