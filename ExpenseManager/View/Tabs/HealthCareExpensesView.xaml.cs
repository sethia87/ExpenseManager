using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for HealthCareExpensesView.xaml
    /// </summary>
    public partial class HealthCareExpensesView : UserControl
    {
        public HealthCareExpensesView()
        {
            InitializeComponent();
            this.DataContext = new HealthCareExpensesViewModel();
        }
    }
}
