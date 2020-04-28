
using System.Security.Cryptography;
using System.Text;

namespace RVTR.Account.ObjectModel.Util
{
  public abstract class Hash
  {
    private static SHA1Managed sha1_state = new SHA1Managed();
    private string _hash = Encoding.Default.GetString(sha1_state.ComputeHash(Encoding.ASCII.GetBytes("hello "))).Substring(0,4); // returns the first 4 chars of the SHA1 hash
   
   public static string hash(string arguments) // default hash is 16 bytes
   {
     return Encoding.Default.GetString(sha1_state.ComputeHash(Encoding.ASCII.GetBytes("hello "+arguments))).Substring(0,16);
   }
   public static string hash(string arguments, int length)
   {
     return Encoding.Default.GetString(sha1_state.ComputeHash(Encoding.ASCII.GetBytes("hello "+arguments))).Substring(0,length);
   }
  }
}
