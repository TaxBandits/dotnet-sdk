# Using the Business API with C#
Business API SDK written on C# in .Net Core framework to show how to integrate with TaxBandits Business API. 

## To get the sandbox keys:
- Go to Sandbox Developer console: https://sandbox.taxbandits.com
- Signup or signin to Sandbox 
- Navigate to **settings** from the left menu and choose **API Credentials**. Copy client id, client secret and user token. 

## Cloning and Running the Application in local
 - Clone the project into your local machine https://github.com/TaxBandits/tbs-dotnet-sdk.git
 - Let's Navigate into the sdk-dotnet folder, then business-sdk folder.

### Packages need to install
To install Packages, right-click on your project in the Solution Explorer window and select “Manage NuGet packages…”. Then, in the NuGet Package Manager window, search for required pacakges and install it.  
 
* System.IdentityModel.Tokens.Jwt:
    - This package for creating, serializing and validating JSON Web Tokens.
* Microsoft.AspNet.WebApi.Client
    - This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.

### How to use?
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Open appsettings.json file and replace with your Client Id, Client Secret and User Token under appsettings tag.
5. Run the BusinessApiSDK application provided for sandbox testing.
    
### Business Method
- Create 
- Get
- List
- Update

## Create Business
For creating business, pass the required data from React Js Application (Frontend) to the Node Js Application(Backend). In Backend, JWT will be generated and passed to the TBS Create Business Endpoint in headers as Authorization. By requesting the TBS Create Business Endpoint, the business will be created and output will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Business/Create]

## List Business
For listing business we are passing page, page size, FromDate as params which is taken from env files and ToDate is taken as current date which is also passed as params and JWT token as headers. By passing these values we request to TBS Public API Base URL.
After requesting list method in business API we'll display the response data as a list.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Business/List]

## Update Business
For updating business we are requesting get business method from Business API and fetch the data against Business ID which is passed as params. After retrieving data we'll update it by requesting TBS Public API Base URL.
After requesting update method in business API, output will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Business/Update]

## Get Business
For getting business we are requesting get business method from Business API and fetch the data against Business ID which is passed as params. After retrieving data, output will be shown in a modal.

**TBS Public API Base URL:** [https://testapi.taxbandits.com/{version}/Business/Update]

In the above URLs, {version} is the endpoint version of TaxBandits API.


## Project Folder Structure
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

    
