namespace AzureMock.Models
{
    public class SqlServer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string ResourceGroup { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string AdminUsername { get; set; } = string.Empty;
        public string AdminPassword { get; set; } = string.Empty;
        public string Version { get; set; } = "12.0";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Running";
        public List<SqlDatabase> Databases { get; set; } = new();
    }
}
