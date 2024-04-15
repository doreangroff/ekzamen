using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ekzamen.Entities;

namespace ekzamen.Windows;

public partial class AddPlayer : Window
{
    public ObservableCollection<Player> MainPlayerList { get; set; }
    public AddPlayer()
    {
        InitializeComponent();
        MainPlayerList = new ObservableCollection<Player>();
    }

    private void AddButton_OnClick(object? sender, RoutedEventArgs e)
    {
        string name = TBName.Text;
        string position = CBPos.SelectedItem.ToString();
        int weight = Convert.ToInt32(TBWeight.Text);
        int height = Convert.ToInt32(TBHeight.Text);
        DateTime birthday = Convert.ToDateTime(BirthDP.SelectedDate);
        DateTime start = Convert.ToDateTime(StartDP.SelectedDate);
        string team = CBTeam.SelectedItem.ToString();
        Player player = new Player(name, position, weight, height, birthday, start, team);
        MainPlayerList.Add(player);
        this.Close();
    }

    private void BackButton_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}