using MauiKITrainer.View;

namespace MauiKITrainer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DashboardView), typeof(DashboardView));
        }
    }
}
