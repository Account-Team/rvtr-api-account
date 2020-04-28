using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models{
  /// <summary>
  /// Basic Location details such as Street Address, City, State, etc.
  /// </summary>
  public class Address : Model
  {
    public string AddressID { get; set; }
    // { get => AddressID ; set{
    //   AddressID = Hash.hash(value);
    // } } 
    [Display(Name = "Street address")]
    [Required(ErrorMessage = "Street address is required.")]
    public string StreetAddress1 { get; set; }
    [Display(Name = "Street address")]
    public string StreetAddress2 { get; set; }
    [Display(Name = "City")]
    [Required(ErrorMessage = "City is required.")]
    public string City { get; set; }
    [Display(Name = "State")]
    [Required(ErrorMessage = "State is required.")]
    public string State { get; set; }
    [Display(Name = "Zip code")]
    [Required(ErrorMessage = "Zip code is required.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Zip code must be numeric.")]
    public string ZipCode { get; set; }
    [Display(Name = "Country")]
    [Required(ErrorMessage = "Country is required.")]
    public string Country { get; set; }

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



