using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for SchoolFeesExpensesView.xaml
    /// </summary>
    public partial class SchoolFeesExpensesView : UserControl
    {
        public SchoolFeesExpensesView()
        {
            InitializeComponent();
            this.DataContext = new SchoolFeesExpensesViewModel();
        }
    }
}
