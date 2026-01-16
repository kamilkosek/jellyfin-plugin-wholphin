using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json;
using Jellyfin.Data.Enums;
using Jellyfin.Plugin.Wholphin.Configuration;
using Jellyfin.Plugin.Wholphin.Models;
using MediaBrowser.Common.Api;
using MediaBrowser.Controller.Dto;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Library;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.Querying;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.Plugin.Wholphin.Api;

/// <summary>
/// API endpoints for Wholphin.
/// </summary>
[ApiController]
[Authorize]
[Route("wholphin")]
public class WholphinPluginController : ControllerBase
{
    private readonly ILibraryManager _libraryManager;
    private readonly IDtoService _dtoService;
    private readonly IUserManager _userManager;

    /// <summary>
    /// Initializes a new instance of the <see cref="WholphinPluginController"/> class.
    /// </summary>
    /// <param name="libraryManager">Library manager for item lookups.</param>
    /// <param name="dtoService">DTO service to map items.</param>
    /// <param name="userManager">User manager for user context.</param>
    public WholphinPluginController(ILibraryManager libraryManager, IDtoService dtoService, IUserManager userManager)
    {
        _libraryManager = libraryManager;
        _dtoService = dtoService;
        _userManager = userManager;
    }

    /// <summary>
    /// Get login background image URL.
    /// </summary>
    /// <returns>URL of the login background image.</returns>
    [AllowAnonymous]
    [HttpGet("loginbackground")]
    [ProducesResponseType(200)]
    public ActionResult GetLoginBackground()
    {
        var cfg = Plugin.Instance?.Configuration;

        return Ok(new
        {
            backgroundUrl = cfg?.LoginBackgroundImageUrl ?? string.Empty,
            alpha = cfg?.LoginBackgroundAlpha ?? 0.2f,
            blur = cfg?.LoginBackgroundBlur ?? 1.0f
        });
    }

    /// <summary>
    /// Get plugin settings.
    /// </summary>
    /// <returns>Plugin settings.</returns>
    [HttpGet("settings")]
    [ProducesResponseType(200)]
    public ActionResult GetSettings()
    {
        var cfg = Plugin.Instance?.Configuration;

        return Ok(new
        {
            seerrUrl = cfg?.SeerrUrl ?? string.Empty,
            themeColor = new
            {
                value = cfg?.ThemeColor?.Value ?? AppThemeColors.PURPLE,
                locked = cfg?.ThemeColor?.Locked ?? false
            }
        });
    }

    /// <summary>
    /// Get home screen configuration.
    /// </summary>
    /// <returns>Home screen configuration with sections.</returns>
    [HttpGet("home")]
    [ProducesResponseType(typeof(HomeConfiguration), 200)]
    [SuppressMessage(category: "Performance", checkId: "CA1869", Target = "Filters", Justification = "Wholphin requires camelCase serialization for the client.")]
    public ActionResult GetHomeConfiguration()
    {
        var cfg = Plugin.Instance?.Configuration;
        var homeConfig = cfg?.HomeConfiguration ?? new HomeConfiguration();

        // Serialize with camelCase for the client
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        var json = JsonSerializer.Serialize(homeConfig, options);
        return Content(json, "application/json");
    }

    /// <summary>
    /// Get navigation drawer configuration.
    /// </summary>
    /// <returns>Navigation drawer configuration with items.</returns>
    [HttpGet("navdrawer")]
    [ProducesResponseType(typeof(NavDrawerConfiguration), 200)]
    [SuppressMessage(category: "Performance", checkId: "CA1869", Target = "Filters", Justification = "Wholphin requires camelCase serialization for the client.")]
    public ActionResult GetNavDrawerConfiguration()
    {
        var cfg = Plugin.Instance?.Configuration;
        var navDrawerConfig = cfg?.NavDrawerConfiguration ?? new NavDrawerConfiguration();

        // Serialize with camelCase for the client
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        var json = JsonSerializer.Serialize(navDrawerConfig, options);
        return Content(json, "application/json");
    }
}
