using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;
using System.Windows.Input;
using ExpenseManager.Command;
using ExpenseManager.Model;

namespace ExpenseManager.ViewModel.Tabs;

internal class CreditCardExpensesViewModel
{
    #region Fields
    private const string UriString = "https://localhost:7018/";
    private const string RequestUri = "api/creditcardexpenses";
    #endregion
    
    #region Properties
    public List<string> CreditCardNameList { get; set; }
    public ObservableCollection<CreditCardExpense> CreditCardExpenses { get; set; } = [];
    public ICommand SaveChangesCommand { get; set; }
    #endregion

    #region Constructor
    public CreditCardExpensesViewModel()
    {
        CreditCardNameList =
        [
            "HDFC Diners",
            "HDFC Rupay",
            "ICICI Rupay",
            "IDFC Wealth",
            "IDFC Ruapy",
            "IndusInd Next",
            "SBI SimpleClick"
        ];

        SaveChangesCommand = new RelayCommand(async (x) => await SaveChanges());
        LoadData();
    }
    #endregion

    #region Methods
    private async Task LoadData()
    {
        using var client = CreateClient();
        var response = await client.GetAsync(RequestUri);

        if (response.IsSuccessStatusCode)
        {
            var expenses = await response.Content.ReadFromJsonAsync<ObservableCollection<CreditCardExpense>>();
            if (expenses != null)
            {
                CreditCardExpenses.Clear();
                foreach (var expense in expenses)
                {
                    expense.IsNew = false;
                    expense.IsModified = false;
                    CreditCardExpenses.Add(expense);
                }
            }
        }
        else
        {
            MessageBox.Show("Error in retreiving data");
        }
    }

    private async Task SaveChanges()
    {
        using var client = CreateClient();
        var changes = CreditCardExpenses.Where(e => e.IsNew || e.IsModified).ToList();
        
        if (changes.Any())
        {
            var response = await client.PostAsJsonAsync(RequestUri, changes);

            if (response.IsSuccessStatusCode)
            {
                foreach (var expense in changes)
                {
                    expense.IsNew = false;
                    expense.IsModified = false;
                }
                MessageBox.Show("Changes saved successfully");
            }
            else
            {
                MessageBox.Show("Failed to save changes");
            }
        }
    }

    private static HttpClient CreateClient()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri(UriString);
        return client;
    }
    #endregion
}
