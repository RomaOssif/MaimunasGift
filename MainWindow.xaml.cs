using System.Windows;

namespace MaimunasGift;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async Task WaitABit()
    {
        await Task.Delay(1000);
    }

    private async Task BSMethod()
    {
        await WaitABit();

        TestBlock1.Text = "Hurray it has changed";
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        BSMethod();
    }
}