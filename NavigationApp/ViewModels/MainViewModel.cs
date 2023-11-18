namespace NavigationApp.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    [ObservableProperty]
    private ViewModelBase _CurrentViewModel = new AdminViewModel();


    [RelayCommand]
    private void ActivateView(string deviceName)
    {

        CurrentViewModel = deviceName switch
        {
            // get it from dependency injection
            "Server" => new ServerConfigureViewModel(),
            "Terminal" => new TerminalConfigureViewModel(),
            "Admin" => new AdminViewModel(),
            _ => throw new ArgumentException($"unknown device name {deviceName}")
        };
    }


}
