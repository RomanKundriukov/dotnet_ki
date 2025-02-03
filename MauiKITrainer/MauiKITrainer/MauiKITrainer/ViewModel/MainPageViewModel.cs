using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiKITrainer.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string _summary = string.Empty;
    }
}
