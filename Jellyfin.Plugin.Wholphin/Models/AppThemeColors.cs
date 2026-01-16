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
    OLEDBLACK = 4,

    /// <summary>
    /// Bold Blue theme.
    /// </summary>
    BOLDBLUE = 5,

    /// <summary>
    /// Unrecognized theme (defaults to Purple).
    /// </summary>
    UNRECOGNIZED = 6
}
