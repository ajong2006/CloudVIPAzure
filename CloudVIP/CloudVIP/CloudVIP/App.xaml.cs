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

            //NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            NavigationService.NavigateAsync("MasterDetail/Navigation/MainPage");

        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MasterDetail>();
            Container.RegisterTypeForNavigation<Navigation>();
            Container.RegisterTypeForNavigation<About>();
            Container.RegisterTypeForNavigation<Appointments>();
            Container.RegisterTypeForNavigation<CreateTime>();
            Container.RegisterTypeForNavigation<ContactUs>();
        }
    }
}
