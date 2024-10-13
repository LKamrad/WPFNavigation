using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WPFNavigation.Core;
using WPFNavigation.MVVM.Model;
using WPFNavigation.Services;

namespace WPFNavigation.MVVM.ViewModel
{
    public class MainViewModel : Core.ViewModel
    {
        private INavigationService _navigation;
        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToSettingsCommand { get; set; }

        public MainViewModel(INavigationService navService, Test test)
        {
             
            Navigation = navService;
            NavigateToHomeCommand = new RelayCommand(o => true, o => { Navigation.NavigateTo<HomeViewModel>(); });
            NavigateToSettingsCommand = new RelayCommand(o => true, o => { Navigation.NavigateTo<SettingsViewModel>(); });

            //set current view
            Navigation.NavigateTo<HomeViewModel>();
        }
    }

}
