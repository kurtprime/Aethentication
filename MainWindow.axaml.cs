using AethenticationPrototype.ViewModels;
using Avalonia.Controls;

namespace AethenticationPrototype;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}