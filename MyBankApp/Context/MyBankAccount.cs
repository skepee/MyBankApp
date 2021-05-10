using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBankApp.Api.Context
{
    [Table("BankAccount")]
    public class MyBankAccount
    {
        [Key]
        public int BankAccountId { get; set; }
        public int UserId { get; set; }
        public string BankAccount { get; set; }
        public string BaseCurrency { get; set; }
        public DateTime DateCreation { get; set; }
        public string Iban { get; set; }

    }
}
