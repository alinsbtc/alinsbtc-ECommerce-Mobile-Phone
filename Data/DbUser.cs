using System;
using System.Collections.Generic;

namespace E_Commerce_Mobile_Phone.Data;

public partial class DbUser
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public string Email { get; set; } = null!;

    public byte Gender { get; set; }

    public string Phone { get; set; } = null!;

    public string Img { get; set; } = null!;

    public DateTime Created { get; set; }

    public byte Trash { get; set; }

    public byte Access { get; set; }

    public byte Status { get; set; }

    public virtual ICollection<DbProducer> DbProducerCreatedByNavigations { get; set; } = new List<DbProducer>();

    public virtual ICollection<DbProducer> DbProducerModifiedByNavigations { get; set; } = new List<DbProducer>();
}
