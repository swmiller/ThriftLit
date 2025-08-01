using System;
using System.Collections.Generic;

namespace ThriftMedia.Data.Models;

public partial class MediaItem
{
    public int MediaId { get; set; }

    public int StoreId { get; set; }

    public string MediaType { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string OcrPayloadJson { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Store Store { get; set; } = null!;
}
