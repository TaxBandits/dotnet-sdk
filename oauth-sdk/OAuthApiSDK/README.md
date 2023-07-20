# Using the OAUTH API with C#
***
OAUTH API SDK written on C# in .Net Core framework to show how to get JWT TOKEN .
## Configuration
 You need to signup with TaxBandits Sandbox Developer Console at https://sandbox.taxbandits.com/User/Register to get the keys to run
the SDK. See below for more directions:
### To get the sandbox keys:
- Go to Sandbox Developer console: https://sandbox.taxbandits.com
- Signup or signin to Sandbox 
- Navigate to **settings** from the left menu and choose **API Credentials**. Copy client id, client secret and user token. 
### The sandbox URLs: (Please make sure to use the right versions)
- Sandbox Auth Server: https://testoauth.expressauth.net/v2/tbsauth 
- API URL: https://testapi.taxbandits.com/v1.7.3 
### How to use?
Below are the steps to get JWT:
1. Sign up for a new developer account in https://sandbox.taxbandits.com/User/Register
2. Navigate to **settings** from the left menu and choose **API Credentials**
3. You can find your Client Id, Client Secret and User Token in the API Credentials page.
4. Note the above credentials and give it as input then Jws is generated.
5. After the JWS created then we request the OAUTH(https://testoauth.expressauth.net/v2/tbsauth) for generating JWT.
6. Once the JWT is created then we have verify the JWT by hitting the api list method in business endpoint.

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
### Contact Details
   Email: developer@taxbandits.com  