using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for YearlyExpensesView.xaml
    /// </summary>
    public partial class YearlyExpensesView : UserControl
    {
        public YearlyExpensesView()
        {
            InitializeComponent();
            this.DataContext = new YearlyExpensesViewModel();
        }
    }
}
