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
        Task.Delay(2000).Wait();

        TestBlock1.Text = "Aha it has changed";



    }
}