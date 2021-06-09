using Xamarin.Forms;
using XamarinForms101_Localization.Helper;

namespace XamarinForms101_Localization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnShowAlert_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert(
                LocalizeHelper.Localize("Message"),
                LocalizeHelper.Localize("HowAreYou"),
                LocalizeHelper.Localize("Ok"));
        }
    }
}
