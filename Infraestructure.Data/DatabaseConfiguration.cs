using Infraestructure.Data;
using Microsoft.Extensions.Configuration;

namespace Infraestructure
{
    public class DatabaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "sisgecpDataConnection";

        private string AuthConnectionKey = "onionAuthConnection";

        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }
        public string GetAuthConnectionString()
        {
            return GetConfiguration().GetConnectionString(AuthConnectionKey);
        }
    }
}
