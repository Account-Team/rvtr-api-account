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
<<<<<<< HEAD
    
    //public string AccountRewardsID { get; set; };

    #region NAVIGATIONAL PROPERTIES
<<<<<<< HEAD
    [ForeignKey("AccountID")]
    public AccountModel AccountModel { get; set; }
=======
    public AccountModel AccountModel { get; set; }
    
    // public string AccountID { get; set; }
>>>>>>> Account Models having issues, but rest of Get requests and some Post Requests work
=======

    #region NAVIGATIONAL PROPERTIES
    public AccountModel AccountModel { get; set; }
    
    // public string AccountID { get; set; }
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a

    #endregion
    
  }
}

