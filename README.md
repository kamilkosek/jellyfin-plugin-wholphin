# Jellyfin Plugin Wholphin

A Jellyfin server plugin that supports the Wholphin Android TV app and provides advanced UI customization options.

## Features

### 🎨 Login Screen Customization
- Customizable background images for the login screen
- Adjustable transparency (alpha) of the background image
- Configurable blur effects

### 🏠 Home Screen Configuration
Flexible home screen configuration with various section types:
- **Resume**: Continue watching content in progress
- **NextUp**: Next episodes in series
- **Latest**: Recently added content
- **Items**: Custom item queries
- **Custom**: Custom plugin endpoints

### Push settings to Wholphin app
Currenlty only pushing the Seerr URL is supported, more settings will follow soon.

## Installation

### Manual Installation

1. Download the latest `Jellyfin.Plugin.Wholphin.dll` from [Releases](https://github.com/kamilkosek/jellyfin-plugin-wholphin/releases)
2. Copy the DLL to your Jellyfin plugin directory:
   - Linux: `/var/lib/jellyfin/plugins/Wholphin/`
   - Windows: `C:\ProgramData\Jellyfin\Server\plugins\Wholphin\`
   - macOS: `/var/lib/jellyfin/plugins/Wholphin/`
3. Restart your Jellyfin server

## API Endpoints

This plugin provides the following API endpoints:

### `GET /wholphin/loginbackground`
Retrieves the login background configuration (no authentication required).

**Response:**
```json
{
  "backgroundUrl": "https://example.com/image.jpg",
  "alpha": 0.2,
  "blur": 1.0
}
```

### `GET /wholphin/settings`
Retrieves plugin settings (authentication required).
Currently only pushing the Seerr URL is supported, more to follow soon.

**Response:**
```json
{
  "seerrUrl": "https://seerr.example.com"
}
```

### `GET /wholphin/home`
Retrieves home screen configuration (authentication required).

**Response:**
```json
{
  "sections": [
    {
      "id": "resume",
      "title": "Continue Watching",
      "type": "Resume",
      "limit": 20
    },
    {
      "id": "nextup",
      "title": "Next Up",
      "type": "NextUp",
      "limit": 20
    }
  ]
}
```

## Configuration

The plugin can be configured through the Jellyfin admin interface:

1. Navigate to **Dashboard** → **Plugins** → **Wholphin**
2. Configure the desired settings:
   - **Login Background Image URL**: URL to the background image
   - **Login Background Alpha**: Transparency (0.0 - 1.0)
   - **Login Background Blur**: Blur strength in dp
   - **Seerr URL**: URL to your Seerr instance
   - **Home Configuration**: JSON configuration for home screen sections

## Development

### Prerequisites
- .NET 8.0 SDK
- Jellyfin 10.9.0 or higher

### Build

```bash
# Using dotnet
dotnet build

# Using Make
make build

# Or build + deploy
make build-and-copy
```

### Project Structure

```
Jellyfin.Plugin.Wholphin/
├── Api/                        # API Controllers
│   └── WholphinPluginController.cs
├── Configuration/              # Plugin configuration
│   ├── configPage.html        # Admin UI
│   └── PluginConfiguration.cs
├── Models/                     # Data models
│   ├── HomeConfiguration.cs
│   ├── HomeSection.cs
│   ├── HomeSectionQuery.cs
│   └── HomeSectionType.cs
├── Plugin.cs                   # Main plugin class
└── ServiceRegistration.cs     # Dependency injection
```

### Tasks

The project includes predefined VS Code tasks:

- **build**: Compiles the plugin
- **deploy-remote**: Deploys the plugin to a remote server
- **build-and-copy**: Build + deploy in one step

## License

See [LICENSE](LICENSE) file for details.

## Author

**Kamil Kosek** ([@kamilkosek](https://github.com/kamilkosek))

## Links

- [Jellyfin](https://jellyfin.org/)
- [Wholphin Android TV App](https://github.com/damontecres/wholphin)

## Changelog

See [GitHub Releases](https://github.com/kamilkosek/jellyfin-plugin-wholphin/releases) for a complete changelog.
