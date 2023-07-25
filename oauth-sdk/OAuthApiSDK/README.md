# Using the OAUTH API with C#
OAUTH API SDK written on C# in .Net Core framework to show how to get JWT TOKEN .

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
 - Let's Navigate into the sdk-dotnet folder,then oauth-sdk.

### Packages need to install
To install Packages, right-click on your project in the Solution Explorer window and select �Manage NuGet packages��. Then, in the NuGet Package Manager window, search for required pacakges and install it.  
 
* System.IdentityModel.Tokens.Jwt:
    - This package for creating, serializing and validating JSON Web Tokens.
* Microsoft.AspNet.WebApi.Client
    - This package adds support for formatting and content negotiation to System.Net.Http. It includes support for JSON, XML, and form URL encoded data.
    
### How to use?
Below are the steps to get JWT:
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Run the OAuthApiSDK application provided for sandbox testing.
5. Note the above API Credentials and give it as input then Jws is generated.
6.  After the JWS created then we request the OAUTH(https://testoauth.expressauth.net/v2/tbsauth) for generating JWT.
7. Once the JWT is created then we can verify the JWT by hitting the api list method in business endpoint.
8. Once you obtain the JWT (Access token), you can use the same JWT along with every API request until the token expires.

Note: Your JWT will expires in One hour from the time of creation.

## Verify JWT
- You can verify your JWT is valid by clicking on the Verify JWT button.
- If there is any business under the User, it will be shown as a list of business by hitting Business/List method.
**Business/List API URL:** [https://testapi.taxbandits.com/v1.7.3/Business/List] 

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