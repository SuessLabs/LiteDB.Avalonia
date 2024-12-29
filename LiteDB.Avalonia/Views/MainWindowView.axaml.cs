using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using LiteDB.Avalonia.ViewModels;

namespace LiteDB.Avalonia.Views;

public partial class MainWindowView : Window
{
  public MainWindowView()
  {
    InitializeComponent();
  }

  private void InitializeComponent()
  {
    AvaloniaXamlLoader.Load(this);
  }

  private void TreeViewItem_OnDoubleTapped(object sender, RoutedEventArgs e)
  {
    // TODO: Move to binding
    if (e.Source is StyledElement { DataContext: TreeNodeViewModel nodeViewModel })
    {
      // ViewModel.CodeSnippedCommand.Execute(nodeViewModel);
    }
  }
}
