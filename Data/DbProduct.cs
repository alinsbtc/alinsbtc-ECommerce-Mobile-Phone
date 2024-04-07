using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbProduct
{
    public int Id { get; set; }

    public int Catid { get; set; }

    public string Name { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public string Img { get; set; } = null!;

    public string SortDesc { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public string Producer { get; set; } = null!;

    public int Number { get; set; }

    public int NumberBuy { get; set; }

    public int? Sale { get; set; }

    public int Price { get; set; }

    public int PriceSale { get; set; }

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Modified { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public byte Trash { get; set; }

    public byte Access { get; set; }

    public byte Status { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public virtual DbCategory Cat { get; set; } = null!;

    public virtual ICollection<DbOrderdetail> DbOrderdetails { get; set; } = new List<DbOrderdetail>();
}
