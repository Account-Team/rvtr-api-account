using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;


namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Contains Reward information for related Account.
  /// </summary>
  public class AccountRewards : Model
  {
    [Key]
    public string AccountRewardsID { get; set; }
    // { get => AccountRewardsID ; set{
    //   AccountRewardsID = Hash.hash(value);
    // } } 
    public string RewardsStatus { get; set; }
    public int RewardsPoints { get; set; }

    #region NAVIGATIONAL PROPERTIES
    [ForeignKey("AccountDetailsID")]
    public AccountDetails AccountDetails { get; set; }

    #endregion
    
  }
}

