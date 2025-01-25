using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using ExpenseManager.Command;
using ExpenseManager.View.Start;

namespace ExpenseManager.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion

        #region Properties
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        private Visibility _monthYearVisibility;
        public Visibility MonthYearVisibility
        {
            get { return _monthYearVisibility; }
            set
            {
                _monthYearVisibility = value;
                OnPropertyChanged(nameof(MonthYearVisibility));
            }
        }
        #endregion

        #region Commands
        public ICommand NavigateCommand { get; }
        #endregion

        public MainViewModel()
        {
            _currentView = new HomeView();
            MonthYearVisibility = Visibility.Visible;
            NavigateCommand = new RelayCommand(Navigate);
        }

        #region Methods
        private void Navigate(object obj)
        {
            MonthYearVisibility = Visibility.Collapsed;
            CurrentView = new StartView();
        }

        private bool CanExecute()
        {
            return true;
        }
        #endregion


        #region EventHandlers
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
