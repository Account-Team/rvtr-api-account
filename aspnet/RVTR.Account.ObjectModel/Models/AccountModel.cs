using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using RVTR.Account.ObjectModel.Util;
// using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;





namespace RVTR.Account.ObjectModel.Models 
{
  public class AccountModel 
  {
    [Key]
    public string AccountID { get => AccountID ; set{
      AccountID = Hash.hash(value);
    } } 
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => throw new System.NotImplementedException();

    public Profile[] Profile { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
    public AccountDetails AccountDetails { get; set; }

  }
}
