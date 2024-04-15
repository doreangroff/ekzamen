using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ekzamen.Entities;

namespace ekzamen.Windows;

public partial class DelWin : Window
{
    private readonly Player _selectedPlayer;
    public ObservableCollection<Player> MainPlayerList { get; set; }
    public DelWin(Player selectedPlayer)
    {
        InitializeComponent();
        MainPlayerList = new ObservableCollection<Player>();
        _selectedPlayer = selectedPlayer;
    }

    private void Yes_OnClick(object? sender, RoutedEventArgs e)
    {
        MainPlayerList.Remove(_selectedPlayer);
        this.Close();
    }

    private void No_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}