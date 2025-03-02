using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniTask_Hub.Utilities;
using System.Windows.Input;

namespace UniTask_Hub.ViewModel
{
    class NavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value; 
                OnPropertyChanged(nameof(CurrentView)); 
            }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand TasksCommand { get; set; }
        public ICommand CalendarCommand { get; set; }
        public ICommand MessagesCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Tasks(object obj) => CurrentView = new TasksVM();
        private void Calendar(object obj) => CurrentView = new CalendarVM();
        private void Messages(object obj) => CurrentView = new MessagesVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            TasksCommand = new RelayCommand(Tasks);
            CalendarCommand = new RelayCommand(Calendar);
            MessagesCommand = new RelayCommand(Messages);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
