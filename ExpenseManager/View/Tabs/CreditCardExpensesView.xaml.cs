using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for CreditCardExpensesView.xaml
    /// </summary>
    public partial class CreditCardExpensesView : UserControl
    {
        public CreditCardExpensesView()
        {
            InitializeComponent();
            this.DataContext = new CreditCardExpensesViewModel();
        }
    }
}
