using System.ComponentModel.DataAnnotations;

// using RVTR.Account.ObjectModel.Interfaces;
using RVTR.Account.ObjectModel.Util;

namespace RVTR.Account.ObjectModel.Models
{
  public class AccountRewards 
  {
    public string AccountRewardsID { get => AccountRewardsID ; set{
      AccountRewardsID = Hash.hash(value);
    } } 
    public string RewardsStatus { get; set; }
    public int RewardsPoints { get; set; }
  }
}
