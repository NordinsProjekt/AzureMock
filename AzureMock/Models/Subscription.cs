namespace AzureMock.Models
{
    public class Subscription
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Azure for Students";
        public string Type { get; set; } = "Student";
        public decimal CreditRemaining { get; set; } = 100.00m;
        public decimal CreditTotal { get; set; } = 100.00m;
        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddMonths(12);
        public string Status { get; set; } = "Active";
        public List<CostEntry> CostHistory { get; set; } = new();
    }

    public class CostEntry
    {
        public DateTime Date { get; set; }
        public decimal Cost { get; set; }
        public string ResourceType { get; set; } = string.Empty;
        public string ResourceName { get; set; } = string.Empty;
    }
}
