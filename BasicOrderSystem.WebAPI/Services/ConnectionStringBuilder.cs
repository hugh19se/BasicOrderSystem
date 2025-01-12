using BasicOrderSystem.Models;
using BasicOrderSystem.WebAPI.Interfaces.Services;
using Microsoft.Data.SqlClient;

namespace BasicOrderSystem.WebAPI.Services
{
    public class ConnectionStringBuilder : IConnectionStringBuilder
    {
        public string GetConnectionString(ConnectionStringConfig connectionStringConfig)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new()
            {
                DataSource = connectionStringConfig.Server,
                InitialCatalog = connectionStringConfig.Database,
                ApplicationName = connectionStringConfig.ApplicationName,
                TrustServerCertificate = true
            };

            if (string.IsNullOrEmpty(connectionStringConfig.Password))
            {
                connectionStringConfig.Password = Environment.GetEnvironmentVariable("ORDERDB_PASSWORD");   
            }

            if (!string.IsNullOrWhiteSpace(connectionStringConfig.Username))
            {
                connectionStringBuilder.IntegratedSecurity = false;
                connectionStringBuilder.UserID = connectionStringConfig.Username;
                connectionStringBuilder.Password = connectionStringConfig.Password;
            }
            else
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }

            return connectionStringBuilder.ConnectionString;
        }
    }
}