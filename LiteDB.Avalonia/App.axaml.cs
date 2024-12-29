using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Markup.Xaml;
using LiteDB.Avalonia.ViewModels;
using LiteDB.Avalonia.Views;
using Prism.DryIoc;
using Prism.Ioc;

namespace LiteDB.Avalonia;

public class App : PrismApplication
{
	internal static IClassicDesktopStyleApplicationLifetime Lifetime => Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;

	public override void Initialize()
	{
		ExpressionObserver.PropertyAccessors.Add(new AvaloniaBsonValuePropertyAccessorPlugin());
		AvaloniaXamlLoader.Load(this);

    // Initialize Prism.Avalonia (required)
    base.Initialize();
	}

	public override void OnFrameworkInitializationCompleted()
	{
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime)
		{
			Lifetime.ShutdownMode = ShutdownMode.OnMainWindowClose;
			Lifetime.MainWindow = new MainWindowView();
		}

		base.OnFrameworkInitializationCompleted();
	}

  protected override IAvaloniaObject CreateShell()
  {
    return Container.Resolve<MainWindowView>();
  }

  protected override void RegisterTypes(IContainerRegistry containerRegistry)
  {
    containerRegistry.RegisterForNavigation<ConnectionView, ConnectionViewModel>();
  }
}
