<<<<<<< HEAD
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Represents the _Account_ model
  /// </summary>
  public class AccountModel : IValidatableObject
  {
<<<<<<< HEAD
    public int Id { get; set; }

    public AddressModel Address { get; set; }

    [Required]
    public string Name { get; set; }

    public IEnumerable<PaymentModel> Payments { get; set; }

    public IEnumerable<ProfileModel> Profiles { get; set; }

    /// <summary>
    /// Represents the _Account_ `Validate` method
    /// </summary>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new List<ValidationResult>();
=======
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => throw new System.NotImplementedException();
=======
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> Added validation annotations and hash fields.
using System.Security.Cryptography;

// using RVTR.Account.ObjectModel.Interfaces;
using RVTR.Account.ObjectModel.Util;

namespace RVTR.Account.ObjectModel.Models 
{
  public class AccountModel 
  {
    public string AccountID { get => AccountID ; set{
      AccountID = Hash.hash(value);
    } } 
    public Profile[] Profile { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
    public AccountDetails AccountDetails { get; set; }
>>>>>>> 172281055 Added object models and Hash Util. Need to fix build errors and change some instance types to hash
>>>>>>> 172281055 Added object models and Hash Util. Need to fix build errors and change some instance types to hash
  }
}
