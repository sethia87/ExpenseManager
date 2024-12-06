using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{
    /// <summary>
    /// Interaction logic for TeacherCoachExpensesView.xaml
    /// </summary>
    public partial class TeacherCoachExpensesView : UserControl
    {
        public TeacherCoachExpensesView()
        {
            InitializeComponent();
            this.DataContext = new TeacherCoachExpensesViewModel();
        }
    }
}
