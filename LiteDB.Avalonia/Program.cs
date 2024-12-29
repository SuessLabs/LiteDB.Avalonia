using System;
using Avalonia;
using Projektanker.Icons.Avalonia;
using Projektanker.Icons.Avalonia.FontAwesome;

namespace LiteDB.Avalonia;

public static class Program
{
  /// <summary>The main entry point for the application.</summary>
  [STAThread]
  private static void Main(string[] args) =>
    BuildAvaloniaApp()
    .StartWithClassicDesktopLifetime(args);

  private static AppBuilder BuildAvaloniaApp() =>
    AppBuilder.Configure<App>()
      .UsePlatformDetect()
      .WithIcons(container => container
        .Register<FontAwesomeIconProvider>());
}
