using System.Configuration;

namespace LiteDB.Avalonia.Properties;

public class Settings : ApplicationSettingsBase
{
    public static Settings Default { get; } = (Settings)Synchronized(new Settings());

    [UserScopedSetting]
    public string ApplicationSettings
    {
        get => (string)this[nameof(ApplicationSettings)];
        set => this[nameof(ApplicationSettings)] = value;
    }
}
