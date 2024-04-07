using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbProducer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Keyword { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateTime Modified { get; set; }

    public int ModifiedBy { get; set; }

    public int Status { get; set; }

    public int Trash { get; set; }

    public virtual DbUser CreatedByNavigation { get; set; } = null!;

    public virtual DbUser ModifiedByNavigation { get; set; } = null!;
}
