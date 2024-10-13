using Microsoft.Extensions.Logging;
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
    public class SettingsViewModel : Core.ViewModel
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

        public SettingsViewModel(INavigationService navigate, Test test)
        {
            Navigation = navigate;
            NavigateToHomeCommand = new RelayCommand(o => true, o => { Navigation.NavigateTo<HomeViewModel>(); });

        }
    }
}
