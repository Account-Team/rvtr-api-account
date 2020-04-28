using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RVTR.Account.ObjectModel.Models
{
  /// <summary>
  /// Represents the _Account_ model
  /// </summary>
  public class AccountModel : IValidatableObject
  {
    publi    public AddressModel Address { get; set; }
c int Id { get; set; }

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
  }
}