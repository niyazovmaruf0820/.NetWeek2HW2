using Domain.Models;
using Infrastructure.Services;


// 1)


CustomerService customerService = new CustomerService();
// Customers customer = new Customers();
// customer.Name = "Alijon";
// customer.Balance = 200000;
// customerService.AddCustomer(customer);

// 2)


// Transactions transaction = new Transactions(1,7,1000);
TransactionService transactionService = new TransactionService();
// transactionService.AddTransaction(transaction);

// 3)

// foreach (var item in customerService.GetTransactionsOfACustomer(1))
// {
//     System.Console.WriteLine(item.SenderId);
//     System.Console.WriteLine(item.RecipientId);
//     System.Console.WriteLine(item.Amount);
//     System.Console.WriteLine(item.TransactionDate);
//     System.Console.WriteLine("-------------------------------");
// }

// 4)

// foreach (var item in transactionService.GetTransactions())
// {
//     System.Console.WriteLine(item.SenderId);
//     System.Console.WriteLine(item.RecipientId);
//     System.Console.WriteLine(item.Amount);
//     System.Console.WriteLine(item.TransactionDate);
// }
 