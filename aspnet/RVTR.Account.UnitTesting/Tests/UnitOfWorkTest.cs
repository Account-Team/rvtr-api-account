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
      var TestEntityAccount = new AccountModel(){ Id = 1, Name = "Name" };
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Account_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var AccountRepo = unWork.AccountModelRepository;
      AccountRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.Account.FirstOrDefault());
    }

    [Fact]
    public void Add_Address_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new AddressModel(){ Id = 1, City = "City", Country = "Country", PostalCode = "Postal", StateProvince = "StateProvince", Street = "Street" };
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Address_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var AccountRepo = unWork.AddressRepository;
      AccountRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.Address.FirstOrDefault());
    }

    [Fact]
    public void Add_BankCard_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new BankCardModel(){ Id = 1, Expiry = new DateTime(), Number = "372695576833849" };
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_BankCard_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var NameRepo = unWork.BankCardRepository;
      NameRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.BankCard.FirstOrDefault());
    }

    [Fact]
    public void Add_Name_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new NameModel(){ Family = "Newt", Given = "Gingrich", Id = 1 };
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Name_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var NameRepo = unWork.NameRepository;
      NameRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.Name.FirstOrDefault());
    }

    [Fact]
    public void Add_Payment_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new PaymentModel(){ Id = 1, BankCard = new BankCardModel(), Name = "Name" };
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Payment_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var NameRepo = unWork.PaymentRepository;
      NameRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.Payment.FirstOrDefault());
    }

    [Fact]
    public void Add_Profile_To_Database()
    {
      var sut = new UnitOfWork(_db);
      var TestEntityAccount = new ProfileModel(){ Id = 1, Email = "User@Example.com", Name = new NameModel(), Phone = "000-000-0000"};
      var options = new DbContextOptionsBuilder<AccountDbContext>() 
          .UseInMemoryDatabase(databaseName: "Add_Profile_to_database")
          .Options;

      // Run the test against one instance of the context
      var context = new AccountDbContext(options);
      var unWork = new UnitOfWork(context);
      var NameRepo = unWork.ProfileRepository;
      NameRepo.Insert(TestEntityAccount);
      unWork.Commit();

      // Use a separate instance of the context to verify correct data was saved to database
      Assert.Equal(TestEntityAccount, context.Profile.FirstOrDefault());
    }
  }
}
