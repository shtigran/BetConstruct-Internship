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


    public class PasswordGenCryptoBit
    {
     
        static public int PassGen(int count)
        {
            int password;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[count];
                rng.GetBytes(data);
                password = BitConverter.ToInt32(data, 0);
            }

            return password;
        }
    }


    public class PasswordGenRandom 
    {
        static Random rand = new Random();

        static public string GetString(byte[] data)
        {
            StringBuilder strb = new StringBuilder();

            foreach (byte b in data)
            {
                string str = b.ToString();
                strb.Append(str);
            }

            return strb.ToString();
        }


        static public string PassGenRand (int count)
        {
            byte[] data = new byte[count];
            rand.NextBytes(data);
            string password = PasswordGenRandom.GetString(data);
            return password;  
        }
    }
}
