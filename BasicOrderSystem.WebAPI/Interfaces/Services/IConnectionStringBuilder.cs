using BasicOrderSystem.Models;

namespace BasicOrderSystem.WebAPI.Interfaces.Services
{
    public interface IConnectionStringBuilder
    {
        string GetConnectionString(ConnectionStringConfig connectionStringConfig);
    }
}