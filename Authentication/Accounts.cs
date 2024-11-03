using System;
using AethenticationPrototype.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AethenticationPrototype.Authentication;

public partial class Accounts : ViewModelBase
{
    [ObservableProperty]
    private string _username = "user";

    [ObservableProperty]
    private string _password = "user";

    [ObservableProperty]
    private bool _isLogin = false;

    public bool Login() => IsLogin = !IsLogin;
}