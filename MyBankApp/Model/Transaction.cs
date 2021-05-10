namespace MyBankApp.Api.Model
{
    public class Transaction
    {
       public int BankAccountId { get; set; }
       public double Quantity { get; set; }
       public string Currency { get; set; }
    }
}
