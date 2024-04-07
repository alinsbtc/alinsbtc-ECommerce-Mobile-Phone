using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Link { get; set; } = null!;

    public int Level { get; set; }

    public int Parentid { get; set; }

    public string? Orders { get; set; }

    public string Color { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public bool Trash { get; set; }

    public bool Access { get; set; }

    public bool Status { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public virtual ICollection<DbProduct> DbProducts { get; set; } = new List<DbProduct>();
}
