using Dapper;
using Domain.Models;
using Infrastructure.Dapper;

namespace Infrastructure.Services;

public class TransactionService
{
    private DapperContext dapperContext = new DapperContext();
    public List<Transactions> GetTransactions()
    {
        return dapperContext.Connection().Query<Transactions>("select * from Transactions").ToList();
    }
    public void TransactionFunction(Transactions transaction)
    {
        dapperContext.Connection().Execute("update Customers set Balance = Balance - @amount where Id = @sId", new { amount = transaction.Amount, sId = transaction.SenderId });
        dapperContext.Connection().Execute("update Customers set Balance = Balance + @amount where Id = @rId", new { amount = transaction.Amount, rId = transaction.RecipientId });
    }
    public void AddTransaction(Transactions transaction)
    {
        dapperContext.Connection().Execute("insert into Transactions(SenderId,RecipientId,Amount,TransactionDate)values(@senderId,@recipientId,@amount,@transactionDate)",transaction);
        TransactionFunction(transaction);
    }
}
