using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExpenseManager.Model;

internal class CreditCardExpense : INotifyPropertyChanged
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }

    private string _cardName = "HDFC Diners";
    public string CardName
    {
        get { return _cardName; }
        set { _cardName = value; OnPropertyChanged(); }
    }

    private DateTime _dueDate = DateTime.Now;
    public DateTime DueDate
    {
        get { return _dueDate; }
        set { _dueDate = value; OnPropertyChanged(); }
    }

    private string? _description;
    public string? Description
    {
        get { return _description; }
        set { _description = value; OnPropertyChanged(); }
    }

    private string? _category;
    public string? Category
    {
        get { return _category; }
        set { _category = value; OnPropertyChanged(); }
    }

    private decimal _amount;
    public decimal Amount
    {
        get { return _amount; }
        set { _amount = value; OnPropertyChanged(); }
    }
    public bool IsNew { get; set; } = true;
    public bool IsModified { get; set; } = false;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}