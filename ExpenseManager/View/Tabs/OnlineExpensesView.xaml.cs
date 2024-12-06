using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for OnlineExpensesView.xaml
    /// </summary>
    public partial class OnlineExpensesView : UserControl
    {
        public OnlineExpensesView()
        {
            InitializeComponent();
            this.DataContext = new OnlineExpensesViewModel();
        }
    }
}
