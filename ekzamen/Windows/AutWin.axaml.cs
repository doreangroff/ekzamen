using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ekzamen.Windows;

namespace ekzamen;

public partial class AutWin : Window
{
    public AutWin()
    {
        InitializeComponent();
        
    }


    private void EnterBut_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow main = new MainWindow();
        main.Show();
        this.Close();
    }
}