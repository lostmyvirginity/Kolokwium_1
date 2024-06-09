namespace Kolokwium_1.Model;

public class CustomerDTORequest
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public int discount { get; set; }
    public List<SubscriptionDTO> subscriptions { get; set; }
}