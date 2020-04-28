using System.Collections.Generic;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext.Repositories
{
  public interface IUnitOfWork
  {
    IRepository<AccountModel> AccountModelRepository { get; }
    IRepository<AddressModel> AddressRepository { get; }
    IRepository<NameModel> NameRepository { get; }
    IRepository<PaymentModel> PaymentRepository { get; }
    IRepository<ProfileModel> ProfileRepository { get; }
    IRepository<BankCardModel> BankCardRepository { get; }
    void Commit();
  }
}
