using System;
using System.Collections.Generic;
using System.Linq;
using FingannTemplate.Services.Navigation.Interfaces;
using GalaSoft.MvvmLight;

namespace FingannTemplate.Services.Navigation
{
    public sealed class NavigationService : ViewModelBase, INavigationService
    {
        private IDisplayable currentViewValue;

        public NavigationService()
        {
            var type = typeof(IDisplayable);

            ViewList = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface)
                .Select(x => Activator.CreateInstance(x) as IDisplayable).ToDictionary(x => x.GetType().Name, x => x);

            currentViewValue = ViewList.First().Value;
        }


        

        public Stack<string> ViewStack { get; set; } = new Stack<string>(5);


        /// <summary>
        ///     The view list.
        /// </summary>
        private Dictionary<string, IDisplayable> ViewList { get; }


        public IDisplayable CurrentView
        {
            get => currentViewValue;

            set
            {
                currentViewValue = value;
                RaisePropertyChanged();
            }
        }

        public string CurrentViewIdentifier => CurrentView.GetType().Name;

        public Dictionary<string, IDisplayable> GetMenuViews
        {
            get
            {
                return ViewList.Where(x => x.Value is IMenuView)
                    .ToDictionary(pair => pair.Value.DisplayTitle, pair => pair.Value);
            }
        }

        public void GoBack()
        {
            var lastView = ViewStack.Pop();
            SetView(lastView);
        }

        public void NavigateTo(string viewIdentifier)
        {
            SetView(viewIdentifier);
            ViewStack.Push(viewIdentifier);
        }

        public void NavigateTo(string viewIdentifier, object parameter)
        {
            ViewList[viewIdentifier].Parameter = parameter;
            ViewStack.Push(viewIdentifier);
        }


        private void SetView(string viewIdentifier)
        {
            CurrentView = ViewList[viewIdentifier];
        }
    }
}