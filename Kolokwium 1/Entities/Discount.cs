﻿using System;
using System.Collections.Generic;

namespace Kolokwium_1.Entities;

public partial class Discount
{
    public int IdDiscount { get; set; }

    public int Value { get; set; }

    public int IdSubscription { get; set; }

    public DateOnly DateFrom { get; set; }

    public DateOnly DateTo { get; set; }

    public virtual Subscription IdSubscriptionNavigation { get; set; } = null!;
}
