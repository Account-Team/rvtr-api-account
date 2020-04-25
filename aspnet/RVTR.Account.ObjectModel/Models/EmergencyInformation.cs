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
    [Key]
    public string EmergencyInformationID { get => EmergencyInformationID ; set{
      EmergencyInformationID = Hash.hash(value);
    } } 
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
    
    [ForeignKey("ProfileID")]
    public Profile Profile { get; set; }

    #endregion

  }
}
