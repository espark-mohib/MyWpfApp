using MyWPFApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFApp.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ExploreViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public ExploreViewModel ExploreVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            ExploreVM = new ExploreViewModel();
            _currentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            ExploreViewCommand = new RelayCommand(o =>
            {
                CurrentView = ExploreVM;
            });

        }

    }
}
