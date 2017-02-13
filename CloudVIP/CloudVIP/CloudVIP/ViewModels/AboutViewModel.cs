using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudVIP.ViewModels
{
    public class AboutViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        string _title = "About Us";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canNavigate = true;
        public bool CanNavigate
        {
            get { return _canNavigate; }
            set { SetProperty(ref _canNavigate, value); }
        }

        public DelegateCommand NavigateCommand { get; set; }

        public AboutViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }

        public void Navigate()
        {
            _navigationService.NavigateAsync("MasterDetail/Navigation/About");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
