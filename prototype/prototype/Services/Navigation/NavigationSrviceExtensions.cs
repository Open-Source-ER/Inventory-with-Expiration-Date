using Prism.Navigation;
using System.Threading.Tasks;

namespace prototype.Services.Navigation
{
    public static class NavigationServiceExtensions
    {
        public static async Task NavigateToMainPage( this INavigationService navigationService)
        {
            await navigationService.NavigateAsync("MainPage/NavigationPage/DashboardPage");
        }

        public static async Task NavigateToSettings(this INavigationService navigationService)
        {
            await navigationService.NavigateAsync("SettingsPage",null,true,true);
        }
    }
}
