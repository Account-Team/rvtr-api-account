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
    public string AccountRewardsID { get; set; }
    // { get => AccountRewardsID ; set{
    //   AccountRewardsID = Hash.hash(value);
    // } } 
    public string RewardsStatus { get; set; }
    public int RewardsPoints { get; set; }

    #region NAVIGATIONAL PROPERTIES
<<<<<<< HEAD
<<<<<<< HEAD
    [ForeignKey("AccountDetailsID")]
=======
>>>>>>> Account Models having issues, but rest of Get requests and some Post Requests work
=======
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a
    public AccountDetails AccountDetails { get; set; }

    #endregion
    
  }
}

