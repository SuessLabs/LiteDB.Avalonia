using System.Collections.ObjectModel;
using System.IO;
using Prism.Commands;

namespace LiteDB.Avalonia.ViewModels;

public class ConnectionViewModel : ViewModelBase
{
    private string _filePath;

    public ConnectionViewModel()
    {
        ////ConnectionStrings = new ObservableCollection<ConnectionString>(
        ////    AppSettingsManager.ApplicationSettings.RecentConnectionStrings
    }

    public string FilePath { get => _filePath; set => SetProperty(ref _filePath, value); }

    public ObservableCollection<ConnectionString> ConnectionStrings { get; }

    public DelegateCommand OpenCommand => new(() =>
    {
        if (!File.Exists(FilePath))
            return;
    });

    public DelegateCommand CloseCommand => new(() =>
    {
        ;
    });

    public DelegateCommand RecentCommand => new(() =>
    {
        //// OpenConnectionStringAndClose();
    });

    private void OpenConnectionStringAndClose(ConnectionString connectionString)
    {
        ////AppSettingsManager.ApplicationSettings.LastConnectionStrings = connectionString;
        ////AppSettingsManager.AddToRecentList(connectionString);
        ////AppSettingsManager.PersistData();
        ////
        ////BroadcastService.Instance.Broadcast(connectionString);
        ////InvertCloseCommand.Execute(connectionString);
    }
}
