using System;
using AethenticationPrototype.Authentication;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AethenticationPrototype.ViewModels;

public partial class MainWindowViewModel: ViewModelBase
{
    [ObservableProperty] private string  _accUsername = "";

    [ObservableProperty] private string  _accPassword = "";

    [ObservableProperty] private string _isLogin = "Login";
    
    [RelayCommand]
    public void LoginButtonClicked()
    {
        Accounts acc = new Accounts();
        FormValidation formValidation = new FormValidation();

        bool validUsername = formValidation.ValidateUsername(AccUsername);
        bool validPassword = formValidation.ValidateUsername(AccPassword);

        Console.WriteLine($"Valid username? {validUsername}");
        Console.WriteLine($"Valid password? {validPassword}");
        
        Console.WriteLine($"username: {acc.Username.ToLower() == AccUsername.ToLower()} ");
        Console.WriteLine($"Password: {AccPassword == acc.Password}");
        if ((AccPassword == acc.Password) && (acc.Username.ToLower() == AccUsername.ToLower())) 
            acc.Login();
        
        IsLogin = acc.IsLogin ? "Logout" : "Login";
    }
    
}