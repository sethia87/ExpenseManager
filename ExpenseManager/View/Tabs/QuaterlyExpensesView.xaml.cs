using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for QuaterlyExpensesView.xaml
    /// </summary>
    public partial class QuaterlyExpensesView : UserControl
    {
        public QuaterlyExpensesView()
        {
            InitializeComponent();
            this.DataContext = new QuaterlyExpensesViewModel();
        }
    }
}
