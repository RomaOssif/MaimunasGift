using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaimunasGift;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    //private void Sleep()
    //{
    //    Thread.Sleep(4000);
    //    //zzz...
    //}

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        Task.Delay(2000).Wait(); //it may be our hope, tho the app will be freezing. still...
        //Sleep();

        TestBlock1.Text = "Aha it has changed";



    }
}