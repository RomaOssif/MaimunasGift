using System.DirectoryServices.ActiveDirectory;
using System.Media;
using System.Windows;
using System.Windows.Controls;
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

    public void UpdateMurkasDialog(string phrase)
    {
        gridDialogMe.Opacity = 0;

        gridDialogCat.Opacity = 90;
        tbMurkasDialog.Text = phrase;
    }

    public void UpdateMyDialog(string phrase)
    {
        gridDialogCat.Opacity = 0;

        gridDialogMe.Opacity = 90;
        tbMyDialog.Text = phrase;
    }

    public void DoSurprise()
    {
        gridSurprisePart.Children.Clear();

        Image murkaImg = new Image();
        murkaImg.Source = new BitmapImage(new Uri("pack://application:,,,/MaimunasGift;component/Images/photo_2025-03-21_14-33-06.jpg"));
        murkaImg.Stretch = Stretch.Fill;

        gridSurprisePart.Children.Add(murkaImg);
        gridDialogMe.Opacity = 80;
    }

    private void OpenGift()
    {
        var uri = new Uri("pack://application:,,,/MaimunasGift;component/Images/gift_PNG100279.png");
        imgPresent.Source = new BitmapImage(uri);
    }

    private async void Button_Click(object sender, RoutedEventArgs e)
    {
        await Task.Delay(1000);

        OpenGift();
        
        PlayMusic();
        
        DoSurprise();

        UpdateMyDialog("Murka?? That's not yours!");
        await Task.Delay(2500);

        UpdateMurkasDialog("Bleh ><\nYou can't make me");
        await Task.Delay(2500);

        UpdateMyDialog("Kitty give it back :0");
        await Task.Delay(3000);

        UpdateMurkasDialog(":3");
        await Task.Delay(3000);

        UpdateMurkasDialog("Crushing the app\nUwU");
        await Task.Delay(4000);
        Application.Current.Shutdown();

    }
}