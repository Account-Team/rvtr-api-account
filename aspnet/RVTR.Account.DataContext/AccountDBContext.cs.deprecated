using Microsoft.EntityFrameworkCore;
using RVTR.Account.ObjectModel.Models;

namespace RVTR.Account.DataContext
{
  public class AccountDbContext: DbContext
  {
    public AccountDbContext(DbContextOptions options) : base(options) {}
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   if (!optionsBuilder.IsConfigured)
    //     {
    //         optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
    //     }
    // }
    public DbSet<AccountDetails> AccountDetails { get; set; }
    public DbSet<AccountModel> Account { get; set; }
    public DbSet<AccountRewards> AccountRewards { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<ContactInformation> ContactInformation { get; set; }
    public DbSet<EmergencyInformation> EmergencyContactInformation { get; set; }
    public DbSet<Name> Name { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Profile> Profile { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder) 
    {
      // Set keys
      builder.Entity<AccountDetails>().HasKey(x => x.AccountDetailsID);
      builder.Entity<AccountModel>().HasKey(x => x.AccountModelID);
      builder.Entity<AccountRewards>().HasKey(x => x.AccountRewardsID);
      builder.Entity<Address>().HasKey(x => x.AddressID);
      builder.Entity<ContactInformation>().HasKey(x => x.ContactInformationID);
      builder.Entity<EmergencyInformation>().HasKey(x => x.EmergencyInformationID);
      builder.Entity<Name>().HasKey(x => x.NameID);
      builder.Entity<Payment>().HasKey(x => x.PaymentID);
      builder.Entity<Profile>().HasKey(x => x.ProfileID);
      // builder.Entity<UserModel>().HasOne(x => x.Feed).WithOne(x => x.User).HasForeignKey<FeedModel>(x => x.uid);  // example
            

      // Define entity relationships
      builder.Entity<AccountDetails>().HasOne(x => x.AccountModel).WithOne(x => x.AccountDetails).HasForeignKey<AccountModel>(x => x.AccountModelID);
      builder.Entity<AccountRewards>().HasOne(x => x.AccountDetails).WithOne(x => x.AccountRewards).HasForeignKey<AccountDetails>(x =>x.AccountDetailsID); 
      builder.Entity<AccountModel>().HasMany(x => x.Profiles).WithOne(x => x.AccountModel);
      builder.Entity<Name>().HasOne(x => x.Profile).WithOne(x => x.Name);
      builder.Entity<Address>().HasOne(x => x.Profile).WithOne(x => x.Address);
      builder.Entity<Payment>().HasOne(x => x.Profile).WithOne(x => x.Payment);
      builder.Entity<ContactInformation>().HasOne(x => x.Profile).WithOne(x => x.ContactInformation);
      builder.Entity<EmergencyInformation>().HasOne(x => x.Profile).WithOne(x => x.EmergencyInformation);
    }
    
    // Input dummy data
    // builder.Entity<UserModel>().HasData(new UserModel[]
    // {
    //     new AccountModel() { UserName = "Alex1234" },
    // });
  }
}