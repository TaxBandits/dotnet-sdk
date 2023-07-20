namespace OAuthApiSDK.Models.Utilities
{
    public class Utility
    {
        #region Get App Settings
        public static string GetAppSettings(string appKey)
        {
            object value = null;
            value = ConfigurationManager.AppSetting.GetSection("AppSettings:" + appKey).Value;
            if (value != null)
            {
                return value.ToString();
            }
            return string.Empty;
        }
        #endregion

        #region ConfigurationManager
        static class ConfigurationManager
        {
            public static IConfiguration AppSetting { get; }
            static ConfigurationManager()
            {
                AppSetting = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
            }
        }
        #endregion
    }
}
