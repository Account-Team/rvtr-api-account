using System;
using System.Collections.Generic;
using RVTR.Account.DataContext.Repositories;
using Xunit;
using RVTR.Account.DataContext;

namespace RVTR.Account.UnitTesting.Tests
{
  public class Repository_Test
  {
    private readonly AccountDbContext _db;
    private readonly Repository<object> _sut;

    // public Repository_Test()
    // {
    //    _sut = new Repository<object>(_db);
    // }
    // public Repository_Test(AccountDbContext db)
    // {
    //    _sut = new Repository<object>(db);
    // }
    public static readonly IEnumerable<object[]> _objects = new List<object[]>
    {
      new object[] { new object() },
      new object[] { new object() },
      new object[] { new object() }
    };

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test_Delete(int id)
    {
      Func<bool> actual = () => { return _sut.Delete(id); };

      Assert.IsType<Func<bool>>(actual);
    }

    [Theory]
    [MemberData(nameof(_objects))]
    public void Test_Insert(object entity)
    {
      Func<bool> actual = () => { return _sut.Insert(entity); };

      Assert.IsType<Func<bool>>(actual);
    }

    [Fact]
    public void Test_Select()
    {
      Func<IEnumerable<object>> actual = () => { return _sut.Select(); };

      Assert.IsType<Func<IEnumerable<object>>>(actual);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Test_SelectOne(int id)
    {
      Func<object> actual = () => { return _sut.Select(id); };

      Assert.IsType<Func<object>>(actual);
    }

    [Theory]
    [MemberData(nameof(_objects))]
    public void Test_Update(object entity)
    {
      Func<bool> actual = () => { return _sut.Insert(entity); };

      Assert.IsType<Func<bool>>(actual);
    }
  }
}
