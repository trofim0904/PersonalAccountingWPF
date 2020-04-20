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
    public class CreateNewCountFirstStepVM : BaseVM
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
        
        public ICommand NextCommand { get; private set; }
        public ICommand BackToAllCountsCommand { get; private set; }



        public CreateNewCountFirstStepVM()
        {

            Types = new ObservableCollection<CountType>()
            {
                new CountType() { Id=1, Name="Наличные деньги" },
                new CountType() { Id=2, Name="Кредит" },
                new CountType() { Id=3, Name="Депозит" }
            };
            NextCommand = new DelegateCommand(NextStep);
            
            
        }

        

        private void NextStep(object obj)
        {
            
            MessageBox.Show(CountType.Name);
            //TODO:
            //Go to another page 
            //Create normal navigation between pages
            //STATE PATERN

        }
    }
}
