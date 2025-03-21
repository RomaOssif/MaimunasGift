using System.Media;
using System.Windows;
using System.Windows.Media;

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


        TestBlock1.Text = "Murka???";
    }
}