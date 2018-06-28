using Prism.Navigation;
using PropertyChanged;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace prototype.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DashboardPageViewModel : ViewModelBase
    {
        public string InventoryNews { get; set; }

        private string _quote;
        public string Quote
        {
            get => _quote;
            set
            {
                _quote = value;
                RaisePropertyChanged();
            }
        }


        public DashboardPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            await Task.Run(async () =>
            {
                try
                {
                    IRestClient client = new RestClient(@"http://quotes.rest/qod.json");
                    var result = await client.ExecuteGetTaskAsync<Rootobject>(new RestRequest(Method.GET));
                    if (result.IsSuccessful)
                    {
                        Quote = result.Data.contents.quotes.ToList().FirstOrDefault()?.quote;
                    }
                }
                catch (System.Exception ex)
                {

                }
            });
            

        }
    }
}




public class Rootobject
{
    public Success success { get; set; }
    public Contents contents { get; set; }
}

public class Success
{
    public int total { get; set; }
}

public class Contents
{
    public Quote[] quotes { get; set; }
    public string copyright { get; set; }
}

public class Quote
{
    public string quote { get; set; }
    public string length { get; set; }
    public object author { get; set; }
    public string[] tags { get; set; }
    public string category { get; set; }
    public string date { get; set; }
    public string permalink { get; set; }
    public string title { get; set; }
    public string background { get; set; }
    public string id { get; set; }
}
