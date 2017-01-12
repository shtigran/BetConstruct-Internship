using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
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


        static public string PassGenRand(int count)
        {
            byte[] data = new byte[count];
            rand.NextBytes(data);
            string password = PasswordGenRandom.GetString(data);
            return password;
        }
    }
}
