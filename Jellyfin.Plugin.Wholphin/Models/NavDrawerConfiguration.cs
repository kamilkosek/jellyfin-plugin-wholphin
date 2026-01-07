using System;
using System.Diagnostics.CodeAnalysis;

namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Configuration for the navigation drawer.
/// </summary>
public class NavDrawerConfiguration
{
    /// <summary>
    /// Gets or sets the navigation drawer items.
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "Items", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public NavDrawerItem[] Items { get; set; } = Array.Empty<NavDrawerItem>();
}
