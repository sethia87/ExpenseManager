﻿using System.Windows.Controls;
using ExpenseManager.ViewModel.Tabs;

namespace ExpenseManager.View.Tabs
{ 
    /// <summary>
    /// Interaction logic for MobileExpense.xaml
    /// </summary>
    public partial class MobileExpenseView : UserControl
    {
        public MobileExpenseView()
        {
            InitializeComponent();
            this.DataContext = new MobileExpenseViewModel();
        }
    }
}
