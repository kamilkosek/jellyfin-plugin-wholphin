using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Home screen configuration for the Wholphin Android TV app.
/// </summary>
public class HomeConfiguration
{
    /// <summary>
    /// Gets or sets the list of home sections.
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "Sections", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public HomeSection[] Sections { get; set; } = Array.Empty<HomeSection>();
}
