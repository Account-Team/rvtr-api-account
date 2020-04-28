using System.Collections.Generic;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public interface IUnitOfWork
  {
    IRepository<AccountModel> AccountModelRepository { get; }
    IRepository<AccountDetails> AccountDetailsRepository { get; }
    IRepository<AccountRewards> AccountRewardsRepository { get; }
    IRepository<Address> AddressRepository { get; }
    IRepository<ContactInformation> ContactInformationRepository { get; }
    IRepository<EmergencyInformation> EmergencyInformationRepository { get; }
    IRepository<Name> NameRepository { get; }
    IRepository<Payment> PaymentRepository { get; }
    IRepository<Profile> ProfileRepository { get; }
    void Commit();
  }
}
