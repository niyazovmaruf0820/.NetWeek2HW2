using Dapper;
using Domain.Models;
using Infrastructure.Dapper;

namespace Infrastructure.Services;

public class CustomerService
{
    private DapperContext dapperContext = new DapperContext();
    public List<Customers> GetCustomers()
    {
        return dapperContext.Connection().Query<Customers>("select * from Customers").ToList();
    }
    public void AddCustomer(Customers customer)
    {
        dapperContext.Connection().Execute("insert into Customers(Name,Balance)values(@name,@balance)", customer);
    }
    public void UpdateCustomer(Customers customer)
    {
        dapperContext.Connection().Execute("update Customers set Name = @name, Balance = @balance where Id = @id", customer);
    }
    public void DeleteCustomer(int id)
    {
        dapperContext.Connection().Execute("delete from Customers where Id = @id", new { Id = id });
    }
    public List<Transactions> GetTransactionsOfACustomer(int id)
    {
        return dapperContext.Connection().Query<Transactions>("select * from Transactions where SenderId = @senderId",new {Id = id}).ToList();
    }
}
