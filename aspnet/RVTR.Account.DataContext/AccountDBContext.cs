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
    public DbSet<AccountModel> Account { get; set; }
    public DbSet<AddressModel> Address { get; set; }
    public DbSet<BankCardModel> BankCard { get; set; }
    public DbSet<NameModel> Name { get; set; }
    public DbSet<PaymentModel> Payment { get; set; }
    public DbSet<ProfileModel> Profile { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder) 
    {
      // Set keys
      builder.Entity<AccountModel>().HasKey(x => x.Id);
      builder.Entity<AddressModel>().HasKey(x => x.Id);
      builder.Entity<NameModel>().HasKey(x => x.Id);
      builder.Entity<PaymentModel>().HasKey(x => x.Id);
      builder.Entity<ProfileModel>().HasKey(x => x.Id);
      builder.Entity<BankCardModel>().HasKey(x => x.Id);            

    }
  }
}