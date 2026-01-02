using System;
using System.Collections.Generic;
using System.Linq;
using Jellyfin.Data.Enums;
using Jellyfin.Plugin.Wholphin.Configuration;
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
        // get the background image URL from configuration
        var backgroundimageurl = cfg?.LoginBackgroundImageUrl ?? string.Empty;
        var alpha = cfg?.LoginBackgroundAlpha ?? 0.2f;
        var blur = cfg?.LoginBackgroundBlur ?? 1.0f;

        return Ok(new
        {
            backgroundUrl = backgroundimageurl,
            alpha = alpha,
            blur = blur
        });
    }

    /// <summary>
    /// Get plugin capabilities.
    /// </summary>
    /// <returns>Plugin version and supported features.</returns>
    [AllowAnonymous]
    [HttpGet("capabilities")]
    [ProducesResponseType(200)]
    public ActionResult GetCapabilities()
    {
        var version = Plugin.Instance?.Version?.ToString() ?? "0.0.0";

        return Ok(new
        {
            version = version,
            features = new
            {
                loginBackground = true,
                settings = true
            }
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
        var seerrUrl = cfg?.SeerrUrl ?? string.Empty;

        return Ok(new
        {
            seerrUrl = seerrUrl
        });
    }
}
