using System;
using System.Collections.Generic;

namespace Kolokwium_1.Entities;

public partial class Subscription
{
    public int IdSubscription { get; set; }

    public string Name { get; set; } = null!;

    public int RenewalPeriod { get; set; }

    public DateOnly EndTime { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
