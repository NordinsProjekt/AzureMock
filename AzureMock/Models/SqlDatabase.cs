namespace AzureMock.Models
{
    public class SqlDatabase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string ServerName { get; set; } = string.Empty;
        public string PricingTier { get; set; } = string.Empty;
        public string ComputeTier { get; set; } = string.Empty;
        public int MaxSizeGB { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Online";
        public string Collation { get; set; } = "SQL_Latin1_General_CP1_CI_AS";
    }
}
