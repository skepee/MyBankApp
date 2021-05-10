using System;

namespace MyBankApp.Api.Model
{
    public class Balance
    {
        public string BankAccount { get; set; }
        public double CurrentBalance { get; set; }
        public string Time { get; set; }
        public string Currency { get; set; }
    }
}
