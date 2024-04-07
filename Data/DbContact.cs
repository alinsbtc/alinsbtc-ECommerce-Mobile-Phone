using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbContact
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int ContactView { get; set; }

    public int Status { get; set; }

    public int Trash { get; set; }

    public string Fullname { get; set; } = null!;
}
