using System.ComponentModel.DataAnnotations;

using System.Security.Cryptography;
using RVTR.Account.ObjectModel.Util;

namespace RVTR.Account.ObjectModel.Abstracts
{
  /// <summary>
  /// References Profile and Account details to display all data related to one Account.
  /// </summary>
  
  public abstract class Model 
  {
    public bool IsValid()
    {
      return true;
    }
  }
}

