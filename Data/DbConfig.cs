using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbConfig
{
    public int Id { get; set; }

    public string MailSmtp { get; set; } = null!;

    public short MailPort { get; set; }

    public string MailInfo { get; set; } = null!;

    public string MailNoreply { get; set; } = null!;

    public string MailPassword { get; set; } = null!;

    public string PriceShip { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Keyword { get; set; } = null!;
}
