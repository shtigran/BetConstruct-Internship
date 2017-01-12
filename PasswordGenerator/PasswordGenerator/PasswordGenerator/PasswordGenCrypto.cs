using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public class PasswordGenCrypto
    {

        static public string GetString(byte [] data)
        {
            StringBuilder strb = new StringBuilder();

            foreach (byte b in data)
            {
                string str = b.ToString();
                strb.Append(str);
            }

            return strb.ToString();
         }
           

        static public string PassGen (int count)
            {
             string password;
             using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
             {
             byte [] data = new byte [count];
             rng.GetBytes(data);
             password = PasswordGenCrypto.GetString(data);
             }
             return password;            
            }                    
    } 
}
