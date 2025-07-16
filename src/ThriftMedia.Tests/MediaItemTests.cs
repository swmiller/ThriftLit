using System;
using ThriftMedia.Data.Models;
using Xunit;

namespace ThriftMedia.Tests;

public class MediaItemTests
{
    [Fact]
    public void MediaItem_CreatedAt_DefaultsToNow()
    {
        var item = new MediaItem();
        Assert.True(item.CreatedAt <= DateTime.Now);
    }
}
