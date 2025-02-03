using MauiKITrainer.ViewModel;

namespace MauiKITrainer.View;

public partial class DashboardView : ContentPage
{
    DashboardViewModel vm = new();
    public DashboardView()
    {
        InitializeComponent();
        BindingContext = vm;
    }
}