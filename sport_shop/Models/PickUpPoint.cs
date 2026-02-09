using System;
using System.Collections.Generic;

namespace sport_shop.Models;

public partial class PickUpPoint
{
    public int Id { get; set; }

    public string Adress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public virtual ICollection<OrdersHistory> OrdersHistories { get; set; } = new List<OrdersHistory>();
}
