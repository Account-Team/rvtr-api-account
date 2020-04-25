using System;
using RVTR.Account.DataContext.Repositories;
using Xunit;
using RVTR.Account.DataContext;
using RVTR.Account.ObjectModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

    // [Fact]
    // public void Test_Accounts()
    // {
    //   var sut = new UnitOfWork(_db);

    //   Assert.True(sut.AccountModelRepository.Insert(new AccountModel()));
    // }

    [Fact]
    public void Add_Account_To_Database()
    {
      var TestEntityName = new Name(){CommonName = "Spiderman", FamilyName = "Arachnids", 
        FullName = "Spiderman the Third", DateOfBirth = DateTime.Now , Title = "Dr.", Suffix = "Jr.", 
        Culture = "Culture", Gender = "Gender", Language = "Language"};
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_name_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var NameRepo = unWork.NameRepository;
      NameRepo.Insert(TestEntityName);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      using(var context2 = new AccountDbContext(options))
      {
        Assert.Equal(1, context2.Name.Count());
        Assert.Equal(TestEntityName, context.Name.Single());
      }
    }
  }
}
