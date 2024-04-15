using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ekzamen.Entities;

namespace ekzamen.Windows;

public partial class MainWindow : Window
{
    public ObservableCollection<Player> _players;
    public MainWindow()
    {
        _players = new ObservableCollection<Player>();
        InitializeComponent();
        Player player1 = new Player("Илюха долматов", "Нападающий", 50, 180, Convert.ToDateTime("10/10/2005"),
            Convert.ToDateTime("10/04/2022"), "Команда 1");
        Player player2 = new Player("Игрок 2", "Защитник", 60, 170, Convert.ToDateTime("10/12/2005"), 
            Convert.ToDateTime("10/04/2023"), "Команда 2");
        Player player3 = new Player("Игрок 2", "Либера", 54, 175, Convert.ToDateTime("16/02/2005"), 
            Convert.ToDateTime("10/04/2024"), "Команда 3");
        _players.Add(player1);
        _players.Add(player2);
        _players.Add(player3);
        PlayersGrid.ItemsSource = _players;
        
    }
    

    private void AddBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        AddPlayer add = new AddPlayer();
        add.ShowDialog(this);
        add.Closed += delegate { PlayersGrid.ItemsSource = _players; };
    }

    private void DelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void SearchTb_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        var searchPlayer = _players.Where(x =>
            x.PlayerName.Contains(SearchTb.Text, StringComparison.OrdinalIgnoreCase) ||
            x.Position.Contains(SearchTb.Text, StringComparison.OrdinalIgnoreCase) ||
            x.Weight.ToString() == SearchTb.Text ||
            x.Height.ToString() == SearchTb.Text ||
            x.Team.Contains(SearchTb.Text, StringComparison.OrdinalIgnoreCase));
        PlayersGrid.ItemsSource = searchPlayer;
        if (SearchTb is null) PlayersGrid.ItemsSource = _players;
        
    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        PlayersGrid.ItemsSource = _players;
    }

    private void PosCb_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var teamComboBox = (ComboBox)sender;
        var curTeam = teamComboBox.SelectedItem as Team;
        var filteredPlayers = _players.Where(x => x.Team == curTeam.TeamName).ToList();
        PlayersGrid.ItemsSource = filteredPlayers;
    }
}