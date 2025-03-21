using System.DirectoryServices.ActiveDirectory;
using System.Media;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MaimunasGift;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void PlayMusic()
    {
        string fileToPlay = "Sounds\\Deltarune-Chapter-2-OST--05---Queen.wav";

        var player = new SoundPlayer(fileToPlay);

        player.Load();
        player.Play();
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(1000);

        PlayMusic();
        
        var uri = new Uri("pack://application:,,,/MaimunasGift;component/Images/gift_PNG100279.png");
        imgPresent.Source = new BitmapImage(uri);

        tbFirstMessage.Text = "Murka?? That's not yours!";
    }
}