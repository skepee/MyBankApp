using Microsoft.EntityFrameworkCore;

namespace MyBankApp.Api.Context
{
    public class MyBankAppContext: DbContext
    {
        protected DbContextOptions<MyBankAppContext> ContextOptions { get; }

        public MyBankAppContext(DbContextOptions<MyBankAppContext> options) : base(options)
        {
            ContextOptions = options;
        }

        public DbSet<MyBankTransaction> Transaction { get; set; }

        public DbSet<MyBankAccount> BankInfo { get; set; }

        public DbSet<MyBankUser> UserInfo { get; set; }



        public void Populate()
        {
            using var context = new MyBankAppContext(ContextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.UserInfo.Add(new MyBankUser()
            {
                UserId = 1,
                DateOfBirth = new System.DateTime(2000, 1, 1),
                LastName = "Surname",
                FirstName = "Name"
            });

            context.BankInfo.Add(new MyBankAccount
            {
                BankAccountId=1,
                BankAccount = "abcrdffw",
                BaseCurrency="GBP",
                DateCreation= new System.DateTime(2020,1,1),
                Iban= "abcdefghilmnopqrstuvz"
            });

            context.Transaction.Add(new MyBankTransaction
            {
                TransactionId = 1,
                BankAccountId = 1,
                DateOperation = new System.DateTime(2021, 5, 5),
                Quantity=100,
                Type="First deposit",
                Verified=true
            });
            ; ;

            context.SaveChanges();
        }
    }
}
