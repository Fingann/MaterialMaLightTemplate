using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FingannTemplate.Services.Navigation.Interfaces;
using FingannTemplate.Services.Notification;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;

namespace FingannTemplate.ViewModel.ViewModels
{
    public class SecoundPageViewModel: IDisplayable, IMenuView
    {
        public string DisplayTitle { get; set; } = "Secound Page";
        public object Parameter { get; set; }
        public INavigationService NavigationService { get; set; }

        public RelayCommand GotoMainPageCommand { get; set; }

        public SecoundPageViewModel()
        {
            
        }
        [PreferredConstructor]
        public SecoundPageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            GotoMainPageCommand = new RelayCommand(() => NavigationService.NavigateTo("MainPageViewModel"));
        }

    }
}
