using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using RVTR.Account.ObjectModel.Util;
<<<<<<< HEAD
// using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;




<<<<<<< HEAD
=======
using RVTR.Account.ObjectModel.Abstracts;
>>>>>>> Working on testin and validation
=======
using System.Security.Cryptography;
using RVTR.Account.ObjectModel.Util;
using RVTR.Account.ObjectModel.Abstracts;
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a

namespace RVTR.Account.ObjectModel.Models 
{
  /// <summary>
  /// References Profile and Account details to display all data related to one Account.
  /// </summary>
  
  public class AccountModel : Model
  {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    // [ForeignKey]
    // public string AccountDetailsID { get => AccountDetailsID ; set{
    //   AccountDetailsID = Hash.hash(value);
    // } } 
    [Key]
    public string AccountID { get => AccountID ; set{
      AccountID = Hash.hash(value);
    } } 
<<<<<<< HEAD
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => throw new System.NotImplementedException();

    public Profile[] Profile { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
=======
=======
    [Key]
=======
>>>>>>> Account Models having issues, but rest of Get requests and some Post Requests work
=======
    [Key]
>>>>>>> Fixed the AccountModelController. Need to fix the other Controllers. There is an issue reading or writing to the database.
=======
    [Key]
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a
    public string AccountModelID { get; set; }
    // { get => AccountModelID ; set{
    //   AccountModelID = Hash.hash(value);
    // } } 
    // public string AccountModelID { get; set; }
<<<<<<< HEAD
>>>>>>> Added the controllers
    public Profile[] Profiles { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
>>>>>>> brancinching
    public AccountDetails AccountDetails { get; set; }

=======
    public Profile[] Profiles { get; set; } // Multiple profiles can be associated with one account, such as wife and kids all on one bill
    public AccountDetails AccountDetails { get; set; }

    public AccountModel()
    {
      uid_state ++;
      AccountModelID = uid_state.ToString();
    }
>>>>>>> faf7247db776ed07a3a1638bab3dae976492b12a
  }
}

