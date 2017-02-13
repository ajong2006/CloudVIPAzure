using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudVIP.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;

        private string _title= "Home";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        async private void Navigate(string name)
        {
            /* If the user ever navigates to the "Make An Appointment"
             * page, the navigation service will make it modal.
             * Otherwise, it will navigate to it normally
             */
            if (name.Equals("Navigation/CreateTime"))
                await _navigationService.NavigateAsync(name, null, true, true);
            else
                await _navigationService.NavigateAsync(name);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            /*
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
            */
        }
    }
}
