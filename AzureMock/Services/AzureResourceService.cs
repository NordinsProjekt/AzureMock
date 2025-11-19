using AzureMock.Models;

namespace AzureMock.Services
{
    public class AzureResourceService
    {
        private readonly List<ResourceGroup> _resourceGroups = new();
        private readonly List<SqlServer> _sqlServers = new();
        private readonly Subscription _subscription;
        private readonly Random _random = new();

        public AzureResourceService()
        {
            // Initialize subscription with simulated cost history
            _subscription = new Subscription
            {
                Name = "Azure for Students",
                Type = "Student",
                CreditTotal = 100.00m,
                Status = "Active",
                ExpiryDate = DateTime.Now.AddMonths(10)
            };

            // Generate 30 days of cost history
            GenerateCostHistory();

            // Calculate credit remaining based on total costs
            var totalCosts = _subscription.CostHistory.Sum(c => c.Cost);
            _subscription.CreditRemaining = _subscription.CreditTotal - totalCosts;

            // Initialize with default resource groups
            _resourceGroups.Add(new ResourceGroup
            {
                Name = "Default-RG",
                Location = "East US"
            });
        }

        private void GenerateCostHistory()
        {
            // Generate random costs for the last 30 days
            var today = DateTime.Now.Date;
            
            for (int i = 29; i >= 0; i--)
            {
                var date = today.AddDays(-i);
                
                // Random number of cost entries per day (0-5)
                int entries = _random.Next(0, 6);
                
                for (int j = 0; j < entries; j++)
                {
                    var resourceTypes = new[] { "SQL Server", "SQL Database", "App Service", "Storage", "Virtual Machine", "Function App" };
                    var resourceType = resourceTypes[_random.Next(resourceTypes.Length)];
                    
                    // Generate random cost between $0.10 and $2.50
                    var cost = (decimal)(_random.NextDouble() * 2.40 + 0.10);
                    cost = Math.Round(cost, 2);
                    
                    _subscription.CostHistory.Add(new CostEntry
                    {
                        Date = date.AddHours(_random.Next(0, 24)).AddMinutes(_random.Next(0, 60)),
                        Cost = cost,
                        ResourceType = resourceType,
                        ResourceName = $"{resourceType.Replace(" ", "")}-{_random.Next(100, 999)}"
                    });
                }
            }
            
            // Sort by date
            _subscription.CostHistory = _subscription.CostHistory.OrderBy(c => c.Date).ToList();
        }

        public Subscription GetSubscription() => _subscription;

        public Dictionary<DateTime, decimal> GetDailyCosts(int days = 30)
        {
            var result = new Dictionary<DateTime, decimal>();
            var today = DateTime.Now.Date;
            
            for (int i = days - 1; i >= 0; i--)
            {
                var date = today.AddDays(-i);
                var dailyCost = _subscription.CostHistory
                    .Where(c => c.Date.Date == date)
                    .Sum(c => c.Cost);
                result[date] = dailyCost;
            }
            
            return result;
        }

        public decimal GetTotalCost() => _subscription.CostHistory.Sum(c => c.Cost);

        public decimal GetCostForPeriod(DateTime start, DateTime end)
        {
            return _subscription.CostHistory
                .Where(c => c.Date >= start && c.Date <= end)
                .Sum(c => c.Cost);
        }

        public List<CostEntry> GetRecentCosts(int count = 10)
        {
            return _subscription.CostHistory
                .OrderByDescending(c => c.Date)
                .Take(count)
                .ToList();
        }

        public Dictionary<string, decimal> GetCostByResourceType()
        {
            return _subscription.CostHistory
                .GroupBy(c => c.ResourceType)
                .ToDictionary(g => g.Key, g => g.Sum(c => c.Cost));
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

        // Add cost when creating resources
        public void CreateSqlServer(SqlServer server)
        {
            _sqlServers.Add(server);
            
            // Add simulated cost
            var cost = (decimal)(_random.NextDouble() * 1.50 + 0.50); // $0.50-$2.00
            _subscription.CostHistory.Add(new CostEntry
            {
                Date = DateTime.Now,
                Cost = cost,
                ResourceType = "SQL Server",
                ResourceName = server.Name
            });

            // Update credit remaining
            _subscription.CreditRemaining -= cost;
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
            var server = _sqlServers.FirstOrDefault(s => s.Name == serverName);
            if (server != null)
            {
                database.ServerName = serverName;
                server.Databases.Add(database);
                
                // Add simulated cost based on pricing tier
                decimal cost = database.PricingTier switch
                {
                    "Basic" => 0.15m,
                    "Standard S0" => 0.25m,
                    "Standard S1" => 0.50m,
                    "Standard S2" => 1.00m,
                    "Premium P1" => 2.00m,
                    "Premium P2" => 3.50m,
                    _ => 0.25m
                };
                
                _subscription.CostHistory.Add(new CostEntry
                {
                    Date = DateTime.Now,
                    Cost = cost,
                    ResourceType = "SQL Database",
                    ResourceName = database.Name
                });

                // Update credit remaining
                _subscription.CreditRemaining -= cost;
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
