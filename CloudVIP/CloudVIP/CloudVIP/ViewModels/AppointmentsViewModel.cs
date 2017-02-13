using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace CloudVIP.ViewModels
{
    public class AppointmentsViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        string _title = "Appointments";
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

        public AppointmentsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }

        public void Navigate()
        {
            _navigationService.NavigateAsync("MasterDetail/Navigation/Appointments");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
