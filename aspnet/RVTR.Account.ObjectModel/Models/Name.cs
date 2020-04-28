using System;
using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Validation;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Contains information on how to interact with user such as Preferred name and Language.
  /// </summary>
  public class Name : Model
  {
    public string NameID { get; set; }
    // { get => NameID ; set{
    //   NameID = Hash.hash(value);
    // } } 
    [Display(Name = "Common name")]
    [Required(ErrorMessage = "Common name is required.")]
    public string CommonName { get; set; }
    [Display(Name = "Family name")]
    [Required(ErrorMessage = "Family name is required.")]
    public string FamilyName { get; set; }
    [Display(Name = "Full name")]
    [Required(ErrorMessage = "Full name is required.")]
    public string FullName { get; set; }
    [Display(Name = "Date of birth")]
    [Required(ErrorMessage = "Date of birth is required.")]
    [DataType(DataType.DateTime)]
    public DateTime DateOfBirth { get; set; }
    [Display(Name = "Title")]
    public string Title { get; set; }
    [Display(Name = "Suffix")]
    public string Suffix { get; set; }
    [Display(Name = "Culture")]
    [Required(ErrorMessage = "Culture is required.")]
    public string Culture { get; set; }
    [Display(Name = "Gender")]
    public string Gender { get; set; }
    [Display(Name = "Language")]
    [Required(ErrorMessage = "Language is required.")]
    public string Language { get; set; }

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
    public new bool IsValid()
    {
      return new ValidateDateOfBirth().IsValid(DateOfBirth);
    }
  }
}

