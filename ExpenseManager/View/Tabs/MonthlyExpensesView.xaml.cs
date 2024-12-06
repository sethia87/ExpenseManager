using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for MonthlyExpensesView.xaml
    /// </summary>
    public partial class MonthlyExpensesView : UserControl
    {
        public MonthlyExpensesView()
        {
            InitializeComponent();
            this.DataContext = new MonthlyExpensesViewModel();
        }
    }
}
