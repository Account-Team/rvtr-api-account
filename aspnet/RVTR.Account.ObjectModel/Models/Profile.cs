using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models 
{
  /// <summary>
  /// References All Objects with data provided by user.
  /// </summary>
  public class Profile : Model
  {
    public string ProfileID { get; set; }
    // { get => ProfileID ; set{
    //   ProfileID = Hash.hash(value);
    // } } 
    
    [Required(ErrorMessage = "Account role is required.")]
    public string AccountRole { get; set; }
    public string ProfilePicture { get; set; } // URI to profile picture
    public ContactInformation ContactInformation { get; set; }
    public Address Address { get; set; }
    public Payment Payment { get; set; }
    public Name Name { get; set; }
    public EmergencyInformation EmergencyInformation { get; set; }

    #region NAVIGATIONAL PROPERTIES
<<<<<<< HEAD
<<<<<<< HEAD
    
    [ForeignKey("AccountID")]
=======
>>>>>>> Account Models having issues, but rest of Get requests and some Post Requests work
=======
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a
    public AccountModel AccountModel { get; set; }

    #endregion
  
  }
}
