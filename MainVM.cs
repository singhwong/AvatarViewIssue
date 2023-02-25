using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvatarViewIssue;

public partial class MainVM : ObservableObject
{
    public MainVM() { }
    [ObservableProperty]
    ImageSource avatarSource;
    [RelayCommand]
    void OnCounter()
    {
        AvatarSource = ImageSource.FromFile("dotnet_bot.png");
    }
}