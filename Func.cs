using System.Reflection;

using System.Configuration;

using OpenAPI.Client;

namespace LineNotify_OpenAPI.Client
{
    public class Func : ClientBase
    {
        string url
        {
            get
            {
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                return config.AppSettings.Settings["API_URL"].Value;
            }
        }

        protected override string API_URL
        {
            get
            {
#if DEBUG
                //return "http://localhost:5258/";
                return url;
#else
                return url;
#endif
            }
        }
    }
}
