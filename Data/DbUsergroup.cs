using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbUsergroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Created { get; set; }

    public int CreatedBy { get; set; }

    public DateTime Modified { get; set; }

    public int ModifiedBy { get; set; }

    public byte Trash { get; set; }

    public byte Access { get; set; }

    public byte Status { get; set; }
}
