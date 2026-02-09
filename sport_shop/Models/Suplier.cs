using System;
using System.Collections.Generic;

namespace sport_shop.Models;

public partial class Suplier
{
    public int Id { get; set; }

    public string SupliersName { get; set; } = null!;

    public virtual ICollection<SportTovar> SportTovars { get; set; } = new List<SportTovar>();
}
