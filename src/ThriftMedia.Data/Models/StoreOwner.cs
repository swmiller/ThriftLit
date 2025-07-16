using System;
using System.Collections.Generic;

namespace ThriftMedia.Data.Models;

public partial class StoreOwner
{
    public int Id { get; set; }

    public string StoreName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<MediaItem> MediaItems { get; set; } = new List<MediaItem>();
}
