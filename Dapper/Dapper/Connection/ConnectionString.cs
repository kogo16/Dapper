using Microsoft.Extensions.Configuration;

namespace Dapper.Connection
{
    public static class ConnectionString
    {
        public static string GetConnectionString(string fileName, string columnName)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile(fileName, optional: false);
            IConfigurationRoot configuration = builder.Build();

            string connection = configuration.GetConnectionString(columnName);

            return connection;
        }
    }
}