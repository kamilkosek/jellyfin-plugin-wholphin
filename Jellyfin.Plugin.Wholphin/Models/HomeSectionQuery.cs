using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Query parameters for home section items.
/// </summary>
public class HomeSectionQuery
{
    /// <summary>
    /// Gets or sets the parent library ID to query from.
    /// </summary>
    public string? ParentId { get; set; }

    /// <summary>
    /// Gets or sets the filters to apply (e.g., "IsUnplayed", "IsFavorite").
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "Filters", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public string[] Filters { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets the item types to include (e.g., "Movie", "Series").
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "IncludeItemTypes", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public string[] IncludeItemTypes { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets the sort fields (e.g., "DateCreated", "PremiereDate").
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "SortBy", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public string[] SortBy { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets the sort order ("Ascending" or "Descending").
    /// </summary>
    public string? SortOrder { get; set; }

    /// <summary>
    /// Gets or sets the genres to filter by.
    /// </summary>
    [SuppressMessage(category: "Performance", checkId: "CA1819", Target = "Genres", Justification = "Xml Serializer doesn't support IReadOnlyList")]
    public string[] Genres { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets a value indicating whether to enable rewatching.
    /// </summary>
    public bool? EnableRewatching { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to enable resumable items.
    /// </summary>
    public bool? EnableResumable { get; set; }
}
