using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prototype.UI.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardView : ContentView
	{
        public static readonly BindableProperty InsideContentProperty = BindableProperty.Create("InsideContent", typeof(View), typeof(CardView), default(View));

        public View InsideContent
        {
            get { return (View)GetValue(InsideContentProperty); }
            set { SetValue(InsideContentProperty, value); }
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(CardView), default(string));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public CardView ()
		{
			InitializeComponent ();
            BindingContext = this;
		}
	}
}