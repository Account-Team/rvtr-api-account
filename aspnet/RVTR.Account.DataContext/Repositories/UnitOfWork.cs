using System;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    
    private readonly AccountDbContext _db;
    public IRepository<AccountModel> AccountModelRepository { get; set; }
    public IRepository<AccountDetails> AccountDetailsRepository { get; set; }
    public IRepository<AccountRewards> AccountRewardsRepository { get; set; }
    public IRepository<Address> AddressRepository { get; set; }
    public IRepository<ContactInformation> ContactInformationRepository { get; set; }
    public IRepository<EmergencyInformation> EmergencyInformationRepository { get; set; }
    public IRepository<Name> NameRepository { get; set; }
    public IRepository<Payment> PaymentRepository { get; set; }
    public IRepository<Profile> ProfileRepository { get; set; }
    public void Dispose()
    {
      _db.Dispose();
    }

    public UnitOfWork(AccountDbContext db)
    {
      _db = db;
      AccountModelRepository = new Repository<AccountModel>(_db);
      AccountDetailsRepository = new Repository<AccountDetails>(_db);
      AccountRewardsRepository = new Repository<AccountRewards>(_db);
      AddressRepository = new Repository<Address>(_db);
      ContactInformationRepository = new Repository<ContactInformation>(_db);
      NameRepository = new Repository<Name>(_db);
      PaymentRepository = new Repository<Payment>(_db);
      ProfileRepository = new Repository<Profile>(_db);
    }

    public void Commit()
    {
      _db.SaveChanges();
    }

  }
}
