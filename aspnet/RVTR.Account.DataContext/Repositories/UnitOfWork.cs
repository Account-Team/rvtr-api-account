using System;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    
    private readonly AccountDbContext _db;
    public IRepository<AccountModel> AccountModelRepository { get; set; }
    public IRepository<AddressModel> AddressRepository { get; set; }
    public IRepository<NameModel> NameRepository { get; set; }
    public IRepository<PaymentModel> PaymentRepository { get; set; }
    public IRepository<ProfileModel> ProfileRepository { get; set; }
    public IRepository<BankCardModel> BankCardRepository { get; set; }
    public void Dispose()
    {
      _db.Dispose();
    }

    public UnitOfWork(AccountDbContext db)
    {
      _db = db;
      AccountModelRepository = new Repository<AccountModel>(_db);
      AddressRepository = new Repository<AddressModel>(_db);
      NameRepository = new Repository<NameModel>(_db);
      PaymentRepository = new Repository<PaymentModel>(_db);
      ProfileRepository = new Repository<ProfileModel>(_db);
      BankCardRepository = new Repository<BankCardModel>(_db);
    }

    public void Commit()
    {
      _db.SaveChanges();
    }

  }
}
