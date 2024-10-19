
#region Secure String Kullanımı
using System.Runtime.InteropServices;
using System.Security;

string bankCardNumber = "1234-5678-9012-3456";
SecureString secureBankCardNumber = new SecureString();
foreach (char c in bankCardNumber)
    secureBankCardNumber.AppendChar(c);

secureBankCardNumber.MakeReadOnly();


#endregion

#region 1.Yöntem
IntPtr bstr = Marshal.SecureStringToBSTR(secureBankCardNumber);
string normalString = Marshal.PtrToStringBSTR(bstr);
Marshal.ZeroFreeBSTR(bstr);
Console.WriteLine(normalString);
#endregion
