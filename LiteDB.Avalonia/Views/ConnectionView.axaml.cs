using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LiteDB.Avalonia.Views;

public partial class ConnectionView : Window
{
  public ConnectionView()
  {
    InitializeComponent();
  }

  private void InitializeComponent()
  {
    AvaloniaXamlLoader.Load(this);
  }
}
