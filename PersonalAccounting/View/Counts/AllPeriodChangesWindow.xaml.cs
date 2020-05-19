using PersonalAccounting.Model.Counts.ModelsForList;
using PersonalAccounting.ViewModel.Counts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonalAccounting.View.Counts
{
    /// <summary>
    /// Логика взаимодействия для AllPeriodChangesWindow.xaml
    /// </summary>
    public partial class AllPeriodChangesWindow : Window
    {
        public AllPeriodChangesWindow(List<PeriodChange> periodChanges)
        {
            InitializeComponent();
            DataContext = new AllPeriodChangeWindowVM(periodChanges);
        }
    }
}
