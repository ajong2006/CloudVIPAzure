using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace CloudVIP.ViewModels
{
    public class MasterDetailViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;

        private MenuModel _selectedListViewChoice;
        public MenuModel SelectedListViewChoice
        {
            get { return _selectedListViewChoice; }
            set
            {
                SetProperty(ref _selectedListViewChoice, value);

                /* Command to navigate to selected ListView item */
                SelectCommand.Execute(_selectedListViewChoice);
            }
        }

        public DelegateCommand<MenuModel> SelectCommand { get; set; }
        public DelegateCommand<string> NavigateCommand { get; set; }

        public MasterDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
            SelectCommand = new DelegateCommand<MenuModel>(NavigateSelected);

        }

        async private void Navigate(string name)
        {
            /* If the user ever navigates to the "Make An Appointment"
             * page, the navigation service will make it modal.
             * Otherwise, it will navigate to it normally
             */
            if (name.Equals("Navigation/CreateTime"))
                await _navigationService.Navigate(name, null, true, true);
            else
                await _navigationService.Navigate(name);
        }

        private void NavigateSelected(MenuModel item)
        {
            Navigate(item.NavName);
        }


        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
