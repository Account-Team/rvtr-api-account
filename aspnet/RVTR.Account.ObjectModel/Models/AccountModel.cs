using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using RVTR.Account.ObjectModel.Util;
<<<<<<< HEAD
// using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;




=======
using RVTR.Account.ObjectModel.Abstracts;
>>>>>>> Working on testin and validation

namespace RVTR.Account.ObjectModel.Models 
{
  /// <summary>
  /// References Profile and Account details to display all data related to one Account.
  /// </summary>
  
  public class AccountModel : Model
  {
    [Key]
    public string AccountID { get => AccountID ; set{
      AccountID = Hash.hash(value);
    } } 
<<<<<<< HEAD
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => throw new System.NotImplementedException();

    public Profile[] Profile { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
=======
    public Profile[] Profiles { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
>>>>>>> brancinching
    public AccountDetails AccountDetails { get; set; }

  }
}

