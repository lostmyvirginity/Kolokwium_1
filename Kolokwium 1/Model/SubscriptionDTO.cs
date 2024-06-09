namespace Kolokwium_1.Model;

public class SubscriptionDTO
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public int RenewalPeriod { get; set; }
    public int TotalPaidAmount { get; set; }
}