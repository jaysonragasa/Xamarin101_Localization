using System.Globalization;
using System.Threading;
using Xamarin.Forms;

namespace XamarinForms101_Localization
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
            //CultureInfo culture = new CultureInfo("fil-PH");
            CultureInfo culture = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = culture;
#endif

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
