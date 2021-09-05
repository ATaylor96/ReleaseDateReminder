using ReminderApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public MovieViewModel MoviesVm { get; set; }

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
            MoviesVm = new MovieViewModel();
            CurrentView = MoviesVm;
        }
    }
}
