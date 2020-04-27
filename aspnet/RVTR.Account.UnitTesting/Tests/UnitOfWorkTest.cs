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

    // Seed Data for each Model type. TODO: fill in the required fields for each of these seed models
    AccountModel account_model = new AccountModel();
    

    private AccountModel BuildAccountModel() // Creates a new AccountModel with dummy data for testing
    {
      // dummy objects initialization
      AccountDetails account_details = new AccountDetails();
      AccountRewards account_rewards = new AccountRewards();
      Address address = new Address();
      Name name = new Name();
      Profile profile = new Profile();
      Payment payment = new Payment();
      ContactInformation contact_information = new ContactInformation();
      EmergencyInformation emergency_information = new EmergencyInformation();
      // Set the dummy objects' values
      //TODO: code here

      // Structure the dummy objects wrt the ER graph
      // TODO: code here

      return account_model;
    }

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
    //   var options = new DbContextOptionsBuilder<AccountDbContext>() 
    //       .UseInMemoryDatabase(databaseName: "AccountDB_Test")
    //       .Options;
    //   var context = new AccountDbContext(options);
    //   var unWork = new UnitOfWork(context);
    //   var AccountModelRepo = unWork.AccountModelRepository;
    //   Assert.True(AccountModelRepo.Insert(new AccountModel()));
    // }

    [Fact]
    public void Add_Account_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new AccountModel(){ AccountModelID = "1"};
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Account_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var AccountModelRepo = unWork.AccountModelRepository;
      AccountModelRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      using(var context2 = new AccountDbContext(options))
      {
        Assert.Equal(TestEntityAccount, context.Account.Single());
      }
    }
  }
}
