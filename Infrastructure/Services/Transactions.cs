using Infrastructure.Dapper;

namespace Infrastructure.Services;
using Dapper;
using Npgsql;
public class Transactions
{
    public Transactions(int sId,int rId,decimal amount)
    {
        SenderId = sId;
        RecipientId = rId;
        Amount = amount;
        TransactionDate = DateTime.Now;
    }
    private DapperContext dapperContext = new DapperContext();
    public int Id { get; set; }
    public int SenderId { get; set; }   
    public int RecipientId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
    
    
}
