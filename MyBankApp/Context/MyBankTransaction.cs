using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankApp.Api.Context
{
    [Table("Transaction")]
    public class MyBankTransaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int BankAccountId { get; set; }
        public string Description { get; set; }
        public DateTime DateOperation { get; set; }
        public Double Quantity { get; set;}
        public string Type { get; set; }
        public bool Verified { get; set; }
    }
}
