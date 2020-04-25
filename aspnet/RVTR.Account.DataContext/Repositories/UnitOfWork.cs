using System;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public class UnitOfWork : IUnitOfWork, IDisposable
  {
    
    private readonly AccountDbContext _db;
    public Repository<AccountModel> AccountModelRepository { get; set; }
    public Repository<AccountDetails> AccountDetailsRepository { get; set; }
    public Repository<AccountRewards> AccountRewardsRepository { get; set; }
    public Repository<Address> AddressRepository { get; set; }
    public Repository<ContactInformation> ContactInformationRepository { get; set; }
    public Repository<EmergencyInformation> EmergencyInformationRepository { get; set; }
    public Repository<Name> NameRepository { get; set; }
    public Repository<Payment> PaymentRepository { get; set; }
    public Repository<Profile> ProfileRepository { get; set; }
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
