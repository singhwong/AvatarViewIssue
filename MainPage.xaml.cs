namespace AvatarViewIssue;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        // avatarView.ImageSource = ImageSource.FromFile("dotnet_bot.png");
        // avatarView.CornerRadius = new CornerRadius(75); ;
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(1);
        avatarView.ImageSource = ImageSource.FromFile("dotnet_bot.png");
    }
}

