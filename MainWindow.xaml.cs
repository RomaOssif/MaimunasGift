using System.Windows;

namespace MaimunasGift;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(1000);

        TestBlock1.Text = "Hurray it has changed";
    }
}