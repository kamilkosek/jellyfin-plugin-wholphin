namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Types of home sections.
/// </summary>
public enum HomeSectionType
{
    /// <summary>
    /// Continue watching section.
    /// </summary>
    Resume,

    /// <summary>
    /// Next episodes section.
    /// </summary>
    NextUp,

    /// <summary>
    /// Recently added items section.
    /// </summary>
    Latest,

    /// <summary>
    /// Custom items query section.
    /// </summary>
    Items,

    /// <summary>
    /// Custom plugin endpoint section.
    /// </summary>
    Custom
}
