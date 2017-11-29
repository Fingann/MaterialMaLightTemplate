using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FingannTemplate.Services.Navigation.Interfaces;
using FingannTemplate.Services.Notification;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace FingannTemplate.ViewModel.ViewModels
{
    public class MainPageViewModel : IDisplayable, IMenuView
    {
        public string DisplayTitle { get; set; } = "Main Page";
        
        public object Parameter { get; set; }
        public INotificationService NotificationService { get; set; }
        public INavigationService NavigationService { get; set; }

        public RelayCommand<double> ShowSuccesNotification { get; set; }
        public RelayCommand ShowInfoNotification { get; set; }
        public RelayCommand ShowWarningNotification { get; set; }
        public RelayCommand ShowExceptionNotification { get; set; }

        public MainPageViewModel()
        {

        }

        [PreferredConstructor]
        public MainPageViewModel(INotificationService notificationService, INavigationService navigationService)
        {
            NotificationService = notificationService;
            NavigationService = navigationService;

            ShowSuccesNotification = new RelayCommand<double>((x) => NotificationService.Success("A success!", "You are awesome","",TimeSpan.FromSeconds(x)));
            ShowInfoNotification = new RelayCommand(() => NotificationService.Info("A Info", "click me to go to Secound Page", onClick: () => NavigationService.NavigateTo("SecoundPageViewModel") ));
            ShowWarningNotification = new RelayCommand(() => NotificationService.Warning("A Warning!!", "You did or did not do something dangerous!"));

            ShowExceptionNotification = new RelayCommand(() => NotificationService.Exception(new Exception("Throwing a exception to display")));
        }
    }
}
