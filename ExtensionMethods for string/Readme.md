# Extension Methods for strings
# C#6  .NET4.6
----

The class library contains folloing extension method for string:

- HasLetter()
- HasNumber()
- HasPunctuation()
- ConCat()
----

### Purpose
The destination of this project and classes to increase string type functionality by extension methods.
----
### Extension Methods  ForStrings class implementation
```c#
public static class ForStrings
{

        public static bool HasLetter (this string str)
        {
            for (int i = 0; i <str.Length; i++)
            {
               if(char.IsLetter(str[i]))
                    return true;
            }
            return false;
        }

        public static bool HasNumber (this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]))
                    return true;
            }
            return false;
        }

        public static bool HasPunctuation (this string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]))
                    return true;
            }
            return false;
        }

        public static string ConCat (this string str, string str1)
        {
            string result = str + str1;
            return result;
        }
             
}
```
### Description of ExtensionMethods ForStrings class
There are several iseful extension methods for strings, which allow You define has the string letter and punctuatuion and also allow 
concat two strings.

### Test 
We invoke this methods in order to illustrate results.
```c#
 string str = "1233424,5";
 string str1 = "Only text";

 Console.WriteLine(str.HasLetter());
 Console.WriteLine(str1.HasLetter());
 Console.WriteLine(str.HasNumber());
 Console.WriteLine(str1.HasNumber());
 Console.WriteLine(str.HasPunctuation());
 Console.WriteLine(str1.HasPunctuation());
 Console.WriteLine(str1.ConCat(str));
```
### Result
False
True
True
False
True
False
Only text1233424,5
