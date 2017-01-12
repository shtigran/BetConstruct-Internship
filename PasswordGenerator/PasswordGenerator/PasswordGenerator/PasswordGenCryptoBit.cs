using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordGenerator
{
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
}
