# Enum indexer
# C#6.0  .NET FRAMEWORK 4.6
----

### Purpose
The destination of this project illustrate the indexer methods. We use DayOfWeek enum to show the ability of indexer.
----
### The indexer class implementation
```c#
public class EnumDays
{
        public int this [string day]
        {

            get
            {
                if (day == DayOfWeek.Monday.ToString() || day == DayOfWeek.Friday.ToString() 
                    || day == DayOfWeek.Saturday.ToString() || day == DayOfWeek.Sunday.ToString() 
                    || day == DayOfWeek.Thursday.ToString() || day == DayOfWeek.Tuesday.ToString() 
                    || day == DayOfWeek.Wednesday.ToString())
                    return (int)(DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                else throw new Exception("The string is not day of week");
            }
        }
}
```

### Description of EnumDays class
We implement the indexer construction, which take the string, compare the days of week and if it's really days of week return that day int. 
In other case return exception.
----
### Test 
```c#
EnumDays day = new EnumDays();
Console.WriteLine($"The Friday is the {day["Friday"]}-th day");
Console.WriteLine($"The Saturday is the {day["Saturday"]}-th day");
Console.WriteLine($"The Monday is the {day["Monday"]}-th day");
```

### Result
The Friday is the 5-th day
The Saturday is the 6-th day
The Monday is the 1-th day

As You can see the indexer take srting and return the in of that string from enum DayOfWeek.
