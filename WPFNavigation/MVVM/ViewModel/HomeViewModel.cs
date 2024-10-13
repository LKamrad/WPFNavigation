using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNavigation.Core;
using WPFNavigation.MVVM.Model;
using WPFNavigation.Services;

namespace WPFNavigation.MVVM.ViewModel
{
    public class HomeViewModel : Core.ViewModel
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

        public RelayCommand NavigateToSettingsCommand { get; set; } 

        public HomeViewModel(INavigationService navigate, Test test)
        {
            Navigation = navigate;
            NavigateToSettingsCommand = new RelayCommand(o => true, o => { Navigation.NavigateTo<SettingsViewModel>(); });
        }

    }
}
