using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB.Avalonia.Models;

namespace LiteDB.Avalonia.ViewModels;

public class TreeNodeViewModel
{
  public TreeNodeViewModel(string name, TreeNodeType type)
  {
    Name = name;
    Type = type;
  }

  public string Name { get; set; }
  public TreeNodeType Type { get; set; }
  public ObservableCollection<TreeNodeViewModel> Nodes { get; set; }

  public string Query { get; set; }

  public string Icon => Type switch
  {
    TreeNodeType.Root => "fas fa-database",
    TreeNodeType.Dictionary => "fas fa-folder-open",
    TreeNodeType.Table => "fas fa-table",
    TreeNodeType.SystemTable => "fas fa-cogs",
    _ => throw new ArgumentOutOfRangeException()
  };
}
