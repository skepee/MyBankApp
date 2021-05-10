using System;

namespace MyBankApp.Api.Model
{
    public class Operation
    {
        public string BankAccount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
    }
}
