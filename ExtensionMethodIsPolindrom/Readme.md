# Extension Method IsPolindrom
# C#6  .NET4.6

----
This project allow You indicate is the integer polindrom or not.
----

### Purpose
We have int variable and we need know does it polindrom or not. For this purpose we use IsPolindrom function.
----

### Polindrom class implementation
```c#
 public static bool IsPolindrom (this int value)
{
            int count = 0, temp1;
            value = Math.Abs(value);
            temp1 = value;
            while (temp1 > 0)
            {
                count++;
                temp1 /= 10;
            }
            if (count == 1)
            {
                return true;
            }

            int result = 0, temp2 = value;
            for (int i = 0; i < count; i++)
            {
                result = result * 10 + temp2 % 10;
                temp2 /= 10;
            }
            if (value == result)
                return true;
            else return false;
        }
}
```  
### Test 
We invoke this method for different integer values.
```c#
int number1 = 525;
Console.WriteLine(number1.IsPolindrom());
number1 = 0;
Console.WriteLine(number1.IsPolindrom());
number1 = 4;
Console.WriteLine(number1.IsPolindrom());
number1 = -2332;
Console.WriteLine(number1.IsPolindrom());
number1 = -1;
Console.WriteLine(number1.IsPolindrom());
number1 = 332;
Console.WriteLine(number1.IsPolindrom());
number1 = 55555;
Console.WriteLine(number1.IsPolindrom());
number1 = 888;
Console.WriteLine(number1.IsPolindrom());
```

### Result

True
True
True
True
True
False
True
True
