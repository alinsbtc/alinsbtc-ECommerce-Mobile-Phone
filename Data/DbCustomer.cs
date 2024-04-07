using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbCustomer
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte? Gender { get; set; }

    public DateOnly Birthday { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime Created { get; set; }

    public bool Trash { get; set; }

    public bool Access { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<DbOrder> DbOrders { get; set; } = new List<DbOrder>();
}
