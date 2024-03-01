using Windows.Gaming.Preview.GamesEnumeration;
namespace Net.Maui.Maths.Game;

public partial class PreviousGames : ContentPage
{
    public PreviousGames()
    {
        InitializeComponent();

        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }

    private void OnDelete(object sender, EventArgs e)
    {
        ImageButton button = (ImageButton)sender;

        App.GameRepository.Delete((int)button.BindingContext);

        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }
}