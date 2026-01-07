namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Represents an item in the navigation drawer.
/// </summary>
public class NavDrawerItem
{
    /// <summary>
    /// Gets or sets the ID of the item (library, collection, or playlist ID).
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the type of the item.
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the display name of the item.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the display order of the item.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the item is visible.
    /// </summary>
    public bool Visible { get; set; } = true;

    /// <summary>
    /// Gets or sets the custom icon URL for the item.
    /// </summary>
    public string? ImageUrl { get; set; }
}
