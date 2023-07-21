namespace Sipay_Api_Second_Week_Assignment;

public class Transaction:IdBaseModel
{
    public int AccountNumber { get; set; }
    //public virtual Account Account { get; set; }
    public decimal CreditAmount { get; set; }   // -
    public decimal DebitAmount { get; set; }    // +
    public string Description { get; set; }
    public DateTime TransactionDate { get; set; } 
    public string ReferenceNumber { get; set; }
}

