using System;
using RVTR.Account.DataContext.Repositories;
using Xunit;
using RVTR.Account.DataContext;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.UnitTesting.Tests
{
  public class UnitOfWork_Test
  {
    private readonly AccountDbContext _db;

    [Fact]
    public void Test_CommitMethod()
    {
      var sut = new UnitOfWork(_db);

      Action actual = () => sut.Commit();

      Assert.IsType<Action>(actual);
    }

    [Fact]
    public void Test_Accounts()
    {
      var sut = new UnitOfWork(_db);

      Assert.True(sut.Accounts.Insert(new AccountModel()));
    }
  }
}
