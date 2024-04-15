using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ekzamen.Windows;

namespace ekzamen;

public partial class AutWin : Window
{
    private int IsManager;
    public AutWin()
    {
        InitializeComponent();
        
    }


    private void EnterBut_OnClick(object? sender, RoutedEventArgs e)
    {
        IsManager = RoleCB.SelectedIndex;
        if (IsManager == -1)
        {
            return;
        }
        MainWindow main = new MainWindow(IsManager);
        main.Show();
        this.Close();
    }
}