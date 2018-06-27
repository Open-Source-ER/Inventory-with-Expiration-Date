using Prism.Ioc;
using prototype.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace prototype.Services.IoC
{
    public static class AutoFacContainerExtensions
    {
        public static IContainerRegistry RegisterPages(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<DashboardPage>();
            containerRegistry.RegisterForNavigation<SettingsPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ItemsPage>();
            return containerRegistry;
        }
        public static IContainerRegistry RegisterDataProviders(this IContainerRegistry containerRegistry, bool useMockData = false)
        {
            if (useMockData)
            {
                //containerRegistry.RegisterInstance<IMenuDataProvider>(new MockMenuDataProvider());
            }
            else
            {

            }
            return containerRegistry;
        }

        public static IContainerRegistry RegisterServices(this IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register(typeof(IDataBaseService), typeof(DataBaseService));
            return containerRegistry;
        }
    }
}
