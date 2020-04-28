using System;
using System.ComponentModel.DataAnnotations;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Contains information on how users plan to pay for services and related informtion.
  /// </summary>
  public class Payment : Model
  {
    [Key]
    public string PaymentID { get; set; }
    // { get => PaymentID ; set{
    //   PaymentID = Hash.hash(value);
    // } } 
    [Display(Name = "Cardholder's name")]
    [Required(ErrorMessage = "Cardholder's name is required.")]
    public string CardholderName { get; set; }
    [Display(Name = "Payment type")]
    [Required(ErrorMessage = "Payment Type is required.")]
    public string PaymentType { get; set; }
    [Display(Name = "Expiration date")]
    [Required(ErrorMessage = "Expiration date is required.")]
    public DateTime ExpirationDate { get; set; }
    [Display(Name = "Card type")]
    [Required(ErrorMessage = "Card type is required.")]
    public string CardType { get; set; }
    [Display(Name = "Card number")]   
    public string CardNumber { get => CardNumber ; set{
      CardNumber = Hash.hash(value);
    } } 
    [Display(Name = "Security number")]
    [Required(ErrorMessage = "Security number is required.")]
    public string SecurityNumber { get => SecurityNumber ; set{
      SecurityNumber = Hash.hash(value);
    } } 
    [Display(Name = "Billing address")]
    [Required(ErrorMessage = "Billing address is required.")]
    public Address BillingAddress { get; set; }

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

