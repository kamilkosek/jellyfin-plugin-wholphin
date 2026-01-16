namespace Jellyfin.Plugin.Wholphin.Models;

/// <summary>
/// Assign a lock to given type value.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class Lockable<T>
{
    /// <summary>
    /// Gets or sets a value indicating whether this setting is locked from user modification.
    /// </summary>
    public bool Locked { get; set; } = false;

    /// <summary>
    /// Gets or sets the value of the setting.
    /// </summary>
    public T Value { get; set; } = default!;
}
