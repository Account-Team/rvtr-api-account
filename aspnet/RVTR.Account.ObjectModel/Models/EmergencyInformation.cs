using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// In case of user Incident, provides information on someone to be contacted.
  /// </summary>
  public class EmergencyInformation
  {
    public string EmergencyInformationID { get; set; }
    // { get => EmergencyInformationID ; set{
    //   EmergencyInformationID = Hash.hash(value);
    // } } 
    [Display(Name = "Name")]
    [Required(ErrorMessage = "Name is required.")]
    public string EmergencyContactName { get; set; }
    [Display(Name = "Relationship")]
    [Required(ErrorMessage = "Relationship is required.")]
    public string Relationship { get; set; }
    [Display(Name = "Email address")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email address is required.")]
    public string Email { get; set; }
    [Display(Name = "Phone number")]
    [MaxLength(20)]
    [MinLength(10)]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Phone number must be numeric.")]
    [Required(ErrorMessage = "Phone number is required.")]
    public string PhoneNumber { get; set; }

    #region NAVIGATIONAL PROPERTIES
<<<<<<< HEAD
<<<<<<< HEAD
    
    [ForeignKey("ProfileID")]
=======
    public string ProfileID { get; set; }
>>>>>>> Account Models having issues, but rest of Get requests and some Post Requests work
=======
    public string ProfileID { get; set; }
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a
    public Profile Profile { get; set; }

    #endregion

  }
}
