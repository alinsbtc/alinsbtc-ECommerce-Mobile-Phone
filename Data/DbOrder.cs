using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbOrder
{
    public int Id { get; set; }

    public string OrderCode { get; set; } = null!;

    public int Customerid { get; set; }

    public DateTime Orderdate { get; set; }

    public string Fullname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Money { get; set; }

    public int Province { get; set; }

    public int District { get; set; }

    public string Address { get; set; } = null!;

    public bool Trash { get; set; }

    public bool Status { get; set; }

    public virtual DbCustomer Customer { get; set; } = null!;

    public virtual ICollection<DbOrderdetail> DbOrderdetails { get; set; } = new List<DbOrderdetail>();
}
