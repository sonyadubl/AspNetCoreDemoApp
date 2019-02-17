using Common.AspNetCoreDemoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemoApp.Common
{
    public static class EnvironmentConfigManager
    {

        public static string GetConnectionString()
        {
            var databaseURL = Environment.GetEnvironmentVariable("DATABASE_URL");

            if (databaseURL == null)
            {
                databaseURL = Environment.GetEnvironmentVariable("DATABASE_URL", EnvironmentVariableTarget.Machine);
            }
            
            var builder = new PostgreSqlConnectionStringBuilder(databaseURL)
            {
                Pooling = true,
                TrustServerCertificate = true,
                SslMode = SslMode.Prefer
            };

            return builder.ToString();
        }

    }
}
