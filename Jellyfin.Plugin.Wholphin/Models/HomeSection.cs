using System.Collections.Generic;

namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Represents a section on the home screen.
/// </summary>
public class HomeSection
{
    /// <summary>
    /// Gets or sets the unique identifier for this section.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the display title for this section.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the type of this section.
    /// </summary>
    public HomeSectionType Type { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of items to display in this section.
    /// </summary>
    public int Limit { get; set; } = 20;

    /// <summary>
    /// Gets or sets the query parameters for Items type sections.
    /// </summary>
    public HomeSectionQuery? Query { get; set; }

    /// <summary>
    /// Gets or sets the custom endpoint for Custom type sections.
    /// </summary>
    public string? Endpoint { get; set; }
}
