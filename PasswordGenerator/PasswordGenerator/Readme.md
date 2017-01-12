# Password Generator 
This project allow You to generate password by diferents ways:

- Generation by Cryptography
- Generation by Cryptography with using BitConverter class method
- Generation by Random 

----

### PasswordGenCrypto class implementation
```
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
```
