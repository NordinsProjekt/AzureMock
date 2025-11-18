using AzureMock.Models;

namespace AzureMock.Services
{
    public class AzureResourceService
    {
        private readonly List<ResourceGroup> _resourceGroups = new();
        private readonly List<SqlServer> _sqlServers = new();

        public AzureResourceService()
        {
            // Add some default resource groups
            _resourceGroups.Add(new ResourceGroup
            {
                Name = "DefaultResourceGroup",
                Location = "East US"
            });
        }

        // Resource Groups
        public List<ResourceGroup> GetResourceGroups() => _resourceGroups;

        public void CreateResourceGroup(ResourceGroup resourceGroup)
        {
            _resourceGroups.Add(resourceGroup);
        }

        public bool ResourceGroupExists(string name) => 
            _resourceGroups.Any(rg => rg.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        // SQL Servers
        public List<SqlServer> GetSqlServers() => _sqlServers;

        public SqlServer? GetSqlServer(string name) => 
            _sqlServers.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public void CreateSqlServer(SqlServer server)
        {
            _sqlServers.Add(server);
        }

        public void DeleteSqlServer(string name)
        {
            var server = GetSqlServer(name);
            if (server != null)
            {
                _sqlServers.Remove(server);
            }
        }

        // SQL Databases
        public void CreateDatabase(string serverName, SqlDatabase database)
        {
            var server = GetSqlServer(serverName);
            if (server != null)
            {
                database.ServerName = serverName;
                server.Databases.Add(database);
            }
        }

        public List<SqlDatabase> GetDatabases(string serverName)
        {
            var server = GetSqlServer(serverName);
            return server?.Databases ?? new List<SqlDatabase>();
        }

        public void DeleteDatabase(string serverName, string databaseName)
        {
            var server = GetSqlServer(serverName);
            if (server != null)
            {
                var database = server.Databases.FirstOrDefault(d => 
                    d.Name.Equals(databaseName, StringComparison.OrdinalIgnoreCase));
                if (database != null)
                {
                    server.Databases.Remove(database);
                }
            }
        }

        // Locations
        public List<string> GetLocations() => new()
        {
            "East US",
            "West US",
            "Central US",
            "North Europe",
            "West Europe",
            "Southeast Asia",
            "East Asia",
            "Australia East",
            "Brazil South",
            "Canada Central",
            "UK South",
            "Japan East"
        };
    }
}
