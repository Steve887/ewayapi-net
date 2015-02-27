using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EWay.Api.Test.Utils
{
    public static class CredentialUtils
    {
        public static NetworkCredential GetTestCredentials()
        {
            var apiKey = ConfigurationManager.AppSettings["eWayAPIKey"];
            var password = ConfigurationManager.AppSettings["eWayAPIPassword"];

            return new NetworkCredential(apiKey, password);
        }
    }
}
