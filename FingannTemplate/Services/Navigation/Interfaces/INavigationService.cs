using System.Collections.Generic;

namespace FingannTemplate.Services.Navigation.Interfaces
{
    public interface INavigationService
    {

        void GoBack();

        void NavigateTo(string pageKey);

        void NavigateTo(string pageKey, object parameter);

        IDisplayable CurrentView { get; set; }

        string CurrentViewIdentifier { get; }

        Dictionary<string, IDisplayable> GetMenuViews { get; }

    }
}
