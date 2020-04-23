using System;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    
    private readonly AccountDbContext _db;
    public Repository<AccountModel> Accounts { get; set; }
    public void Commit() => throw new NotImplementedException();

    public void Dispose()
    {
      _db.Dispose();
    }

    public UnitOfWork(AccountDbContext db)
    {
      _db = db;
    }

  }
}
