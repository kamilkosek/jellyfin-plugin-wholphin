using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using Jellyfin.Plugin.Wholphin.Models;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Wholphin.Configuration;

/// <summary>
/// Plugin configuration for the Wholphin plugin.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Gets or sets the login background image URL.
    /// </summary>
    public string LoginBackgroundImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the alpha (opacity) value for the login background image.
    /// </summary>
    public float LoginBackgroundAlpha { get; set; } = 0.2f;

    /// <summary>
    /// Gets or sets the blur value (in dp) for the login background image.
    /// </summary>
    public float LoginBackgroundBlur { get; set; } = 1.0f;

    /// <summary>
    /// Gets or sets the Seerr URL.
    /// </summary>
    public string SeerrUrl { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the theme color.
    /// </summary>
    public Lockable<AppThemeColors> ThemeColor { get; set; } = new() { Value = AppThemeColors.PURPLE };

    /// <summary>
    /// Gets or sets the home screen configuration.
    /// </summary>
    public HomeConfiguration HomeConfiguration { get; set; } = new()
    {
        Sections = Array.Empty<HomeSection>()
    };

    /// <summary>
    /// Gets or sets the navigation drawer configuration.
    /// </summary>
    public NavDrawerConfiguration NavDrawerConfiguration { get; set; } = new()
    {
        Items = Array.Empty<NavDrawerItem>()
    };
}
