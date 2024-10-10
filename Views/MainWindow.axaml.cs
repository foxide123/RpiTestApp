using Avalonia.Controls;

namespace RpiTestApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Width = 582;
        this.Height = 372+30; 
    }
}