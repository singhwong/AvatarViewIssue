namespace AvatarViewIssue;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new MainVM();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        
    }
}

