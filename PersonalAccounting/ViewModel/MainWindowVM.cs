using PersonalAccounting.Model.WindowState;
using PersonalAccounting.Services;
using PersonalAccounting.ViewModel.Counts;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private BaseVM _selectedViewModel;
        public BaseVM SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }

        private float _cancelButtonVisibility;
        public float CancelButtonVisibility
        {
            get => _cancelButtonVisibility;
            set
            {
                _cancelButtonVisibility = value;
                OnPropertyChanged("CancelButtonVisibility");
            }
        }

        private bool _windowWorkSpaceIsEnable;
        public bool WindowWorkSpaceIsEnable
        {
            get => _windowWorkSpaceIsEnable;
            set
            {
                _windowWorkSpaceIsEnable = value;
                OnPropertyChanged("WindowWorkSpaceIsEnable");
            }
        }
        private float _windowWorkSpaceOpacity;
        public float WindowWorkSpaceOpacity
        {
            get => _windowWorkSpaceOpacity;
            set
            {
                _windowWorkSpaceOpacity = value;
                OnPropertyChanged("WindowWorkSpaceOpacity");
            }
        }
        private bool _lockImgVisibility;
        public bool LockImgVisibility
        {
            get => _lockImgVisibility;
            set
            {
                _lockImgVisibility = value;
                OnPropertyChanged("LockImgVisibility");
            }
        }

        private WeatherModel _weatherModel;
        public WeatherModel WeatherModel
        {
            get => _weatherModel;
            set
            {
                _weatherModel = value;
                OnPropertyChanged("WeatherModel");
            }
        }

        private WeatherProcessor weatherProcessor;
        private WindowContext _windowContext;

        public MainWindowVM()
        {

            SelectedViewModel = new AllCountsVM();

            CancelButtonVisibility = 0;

            ApiHelper.InitializeClient();
            weatherProcessor = new WeatherProcessor();
            GetWeather();
            
            _windowContext = new WindowContext(new UnLockWindow());
            SetWindowState();

            NewCountCommand = new DelegateCommand(NewCount);
            CountPageCommand = new DelegateCommand(CountPage);
            BackToAllCountsCommand = new DelegateCommand(BackToAllCounts);
            CloseAppCommand = new DelegateCommand(CloseApp);
            LockWindowCommand = new DelegateCommand(LockWindow);
        }

        private async void GetWeather()
        {
            WeatherModel = await weatherProcessor.LoadWeather();   
        }

        private void LockWindow(object obj)
        {
            _windowContext.LockWindowClick();
            SetWindowState();
        }

        private void CloseApp(object obj)
        {
            if (!(obj is Window window))
                return;
            window.Close();
        }

        private void BackToAllCounts(object obj)
        {
            SelectedViewModel = new AllCountsVM();
            CancelButtonVisibility = 0;
        }

        private void CountPage(object obj)
        {
            SelectedViewModel = new AllCountsVM();
            CancelButtonVisibility = 0;
        }

        private void NewCount(object obj)
        {

            SelectedViewModel = new CreateNewCountVM();
            CancelButtonVisibility = 1;
        }


        public ICommand BackToAllCountsCommand { get; private set; }
        public ICommand CountPageCommand { get; private set; }
        public ICommand NewCountCommand { get; private set; }
        public ICommand CloseAppCommand { get; private set; }
        public ICommand NextCommand { get; private set; }
        public ICommand LockWindowCommand { get; private set; }


        private void SetWindowState()
        {
            WindowWorkSpaceOpacity = _windowContext.GetWindowWorkSpaceOpacity();
            WindowWorkSpaceIsEnable = _windowContext.GetWindowWorkSpaceIsEnable();
            LockImgVisibility = _windowContext.GetLockImgVisibility();
        }


    }

}
