using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbContent
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Introtext { get; set; } = null!;

    public string Fulltext { get; set; } = null!;

    public string Img { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Modified { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public bool Trash { get; set; }

    public bool Access { get; set; }

    public bool Status { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;
}
