using Prism.Unity;
using CloudVIP.Views;

namespace CloudVIP
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

           // NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            NavigationService.NavigateAsync("About");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<About>();
        }
    }
}
