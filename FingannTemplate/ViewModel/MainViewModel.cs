using GalaSoft.MvvmLight;
using FingannTemplate.Model;
using FingannTemplate.Services.Navigation.Interfaces;
using FingannTemplate.Services.Notification;
using MahApps.Metro.Controls.Dialogs;

namespace FingannTemplate.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService dataService;
        private bool _dialogHostIsOpen;
        public INavigationService NavigationService { get; set; }
        public INotificationService NotificationService { get; set; }
        private IDialogCoordinator DialogCoordinator { get; }


        public bool DialogHostIsOpen
        {
            get { return _dialogHostIsOpen; }
            set
            {
                _dialogHostIsOpen = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService,
            IDialogCoordinator dialogCoordinator,
            INavigationService navigationService)
        {
            this.dataService = dataService;
            this.NavigationService = navigationService;
            this.DialogCoordinator = dialogCoordinator;
            this.dataService = dataService;
            this.dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                   
                });
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}