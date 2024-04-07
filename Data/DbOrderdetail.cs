using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbOrderdetail
{
    public int Id { get; set; }

    public int Orderid { get; set; }

    public int Productid { get; set; }

    public int Count { get; set; }

    public int Price { get; set; }

    public bool Trash { get; set; }

    public bool Status { get; set; }

    public virtual DbOrder Order { get; set; } = null!;

    public virtual DbProduct Product { get; set; } = null!;
}
