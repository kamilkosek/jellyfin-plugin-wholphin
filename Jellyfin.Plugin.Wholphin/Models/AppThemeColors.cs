namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Available theme colors for Wholphin client.
/// </summary>
public enum AppThemeColors
{
    /// <summary>
    /// Purple theme.
    /// </summary>
    PURPLE = 0,

    /// <summary>
    /// Blue theme.
    /// </summary>
    BLUE = 1,

    /// <summary>
    /// Green theme.
    /// </summary>
    GREEN = 2,

    /// <summary>
    /// Orange theme.
    /// </summary>
    ORANGE = 3,

    /// <summary>
    /// OLED Black theme.
    /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
    OLED_BLACK = 4,
#pragma warning restore CA1707 // Identifiers should not contain underscores

    /// <summary>
    /// Bold Blue theme.
    /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
    BOLD_BLUE = 5,
#pragma warning restore CA1707 // Identifiers should not contain underscores

    /// <summary>
    /// Unrecognized theme (defaults to Purple).
    /// </summary>
    UNRECOGNIZED = 6
}
