# MyBankApp
Example of App Bank using WebApi .Net5 and Angular2.
Use of Visual Studio 2019 with .Net5 for WebApi project.

Ths solution is formed by different projects:
* Database
* WebApi
* Unit test (just one simple example, not completed)
* Front End inteface (using Angular2 in Visual Studio Code)


# Features of the project.
Use of:
* Dependency Injection
* ILogger<>
* Repository Pattern
* Custom HttpClient to call api service from thirdy part.
* IHttpClientFactory
* EntityFrameworkCore
* Swashbuckle


 The database is formed by threee tables. By using this structure any user can have multiple bank accounts with different currencies. The tables are:
  * User
    * [UserId]
    *	[FirstName] 
	  * [LastName]
	  * [DateOfBirth],
	  
  * BankAccount
    * [BankAccountId]
    *	[UserId]
    *	[BankAccount]
    *	[BaseCurrency]
    *	[DateCreation]
    *	[Iban]
    
  * Transaction
    * [TransactionId]
	  * [BankAccountId]
	  * [Description]
	  * [DateOperation]
	  * [Quantity]
	  * [Type]
	  * [Verified]


The Front End consists in a simple page with components:
* Balance
  * creation of Balance service and get the value of current balance of the user (HTTPGET).
* Deposit
  * creation of Deposit service and post an amount to add to the bank accont. It handles different currencies.


