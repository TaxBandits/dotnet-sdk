using System.ComponentModel.DataAnnotations;

namespace BusinessApiSDK.Models.Utilities
{
    public static class Utility
    {
        #region Seperate class for configuration manager
        /// <summary>
        /// ConfigurationManager
        /// </summary>
        static class ConfigurationManager
        {
            public static IConfiguration AppSetting { get; }
            static ConfigurationManager()
            {
                AppSetting = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
            }
        }
        #endregion

        #region Get Enum Display Name values
        public static string GetEnumDisplayName(this Enum value)
        {
            var type = value.GetType();   //will get the enum name which matches the input enum value
            if (type.IsEnum)
            {
                var members = type.GetMember(value.ToString());  // will get the member type
                if (members.Length > 0)
                {
                    var member = members[0];
                    var attributes = member.GetCustomAttributes(typeof(DisplayAttribute), false);  // gets the custom attribute we described in enum
                    if (attributes.Length > 0)
                    {
                        var attribute = (DisplayAttribute)attributes[0];
                        return attribute.GetName();     // returns the display name string
                    }
                }
            }
            return string.Empty;
        }
        #endregion

        #region Get App Settings
        /// <summary>
        /// Get the appsetting value from the web.config
        /// </summary>
        /// <param name="appKey">appsettings key</param>
        /// <returns></returns>
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

        #region Convert to Int
        /// <summary>
        /// Convert to Int.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static int GetInt(object value)
        {
            int result = 0;
            if (value != null)
            {
                int.TryParse(value.ToString(), out result);
            }
            return result;
        }
        #endregion
    }
}
