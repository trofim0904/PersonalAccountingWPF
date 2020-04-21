using PersonalAccounting.Model.Count;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

        public CreateNewCountVM()
        {
           

            SecondPartEnable = false;
            SecondPartOpacity = 0;
            Types = new ObservableCollection<CountType>()
            {
                new CountType() { Id=1, Name="Наличные деньги" },
                new CountType() { Id=2, Name="Кредит" },
                new CountType() { Id=3, Name="Депозит" }
            };


            SelectTypeCommand = new DelegateCommand(SelectType);
        }

        private void SelectType(object obj)
        {
            if (CountType == null)
                return;

            if (CountType.Id == 1)
            {
                //TODO
                
            }
            SecondPartEnable = true;
            SecondPartOpacity = 1;
        }

    }
    
}
