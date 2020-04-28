using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Account Details [Considering Merge with AccountModel.cs...]
  /// </summary>
  public class AccountDetails : Model
  {
    public string AccountDetailsID { get; set; }
    // { get => AccountDetailsID ; set{
    //   AccountDetailsID = Hash.hash(value);
    // } } 
    [Display(Name = "Account type")]
    [Required(ErrorMessage = "Account type is required.")]
    public string AccountType { get; set; }
    public AccountRewards AccountRewards { get; set; }
    
    //public string AccountRewardsID { get; set; };

    #region NAVIGATIONAL PROPERTIES
    public AccountModel AccountModel { get; set; }
    
    // public string AccountID { get; set; }

    #endregion
    
  }
}

