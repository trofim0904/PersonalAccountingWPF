using PersonalAccounting.Model.Counts;
using PersonalAccounting.Model.Counts.CreateCount;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace PersonalAccounting.ViewModel.Counts
{
    public class CreateNewCountVM : BaseVM
    {
        private ObservableCollection<CountType> _types;
        public ObservableCollection<CountType> Types
        {
            get => _types;
            set
            {
                _types = value;
                OnPropertyChanged("Types");
            }

        }
        private ObservableCollection<ValutaType> _valutatypes;
        public ObservableCollection<ValutaType> ValutaTypes
        {
            get => _valutatypes;
            set
            {
                _valutatypes = value;
                OnPropertyChanged("ValutaTypes");
            }

        }

        private CountType _countType;
        public CountType CountType
        {
            get => _countType;
            set
            {
                _countType = value;
                OnPropertyChanged("CountType");
            }
        }

        private InputCountParametrs _inputParametrs;
        public InputCountParametrs InputParametrs
        {
            get => _inputParametrs;
            set
            {
                _inputParametrs = value;
                OnPropertyChanged("InputParametrs");
            }
        }

        private bool _secondPartEnable;
        public bool SecondPartEnable
        {
            get => _secondPartEnable;
            set
            {
                _secondPartEnable = value;
                OnPropertyChanged("SecondPartEnable");
            }
        }
        private float _secondPartOpacity;
        public float SecondPartOpacity
        {
            get => _secondPartOpacity;
            set
            {
                _secondPartOpacity = value;
                OnPropertyChanged("SecondPartOpacity");
            }
        }

      

        public ICommand SelectTypeCommand { get; private set; }
        public ICommand CreateNewCountCommand { get; private set; }

        public CreateNewCountVM()
        {
            InputParametrs = new InputCountParametrs();

            SecondPartEnable = false;
            SecondPartOpacity = 0;
            
            Types = new ObservableCollection<CountType>(CountType.CountTypes);
            ValutaTypes = new ObservableCollection<ValutaType>(ValutaType.ValutaTypes);
            
            CreateNewCountCommand = new DelegateCommand(CreateNewCount);
            SelectTypeCommand = new DelegateCommand(SelectType);
        }

        private void CreateNewCount(object obj)
        {
            if (Count.CreateAction(InputParametrs))
            {
                MessageBox.Show("Добавлено");
                InputParametrs = new InputCountParametrs();
                

            }
            else
            {
                MessageBox.Show("Ошибка");
            }



            
        }

        private CountCreation _count;
        public CountCreation Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged("Count");
            }
        }

        private void SelectType(object obj)
        {
            if (CountType == null)
                return;
            
            SecondPartEnable = true;
            SecondPartOpacity = 1;

            Count = new RefindCountCreation(CountType.CountTypes[CountType.Id - 1].SelectedCount);
            

        }

    }
    
}
