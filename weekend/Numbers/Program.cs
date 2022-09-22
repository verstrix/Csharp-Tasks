try
{
    Console.WriteLine("Chooase a day of the week 1 - 7");
    var day = int.Parse(Console.ReadLine());
    string dayOfWeek = "";
    var daysToWeekend = 6 - day;



    switch (day)
    {
        case 1: dayOfWeek = "Monday"; break;
        case 2: dayOfWeek = "Tuesday"; break;
        case 3: dayOfWeek = "Wednesday"; break;
        case 4: dayOfWeek = "Thursday"; break;
        case 5: dayOfWeek = "Friday"; break;
        case 6: dayOfWeek = "Saturday"; break;
        case 7: dayOfWeek = "Sunday"; break;
        default: Console.WriteLine("Error!"); break;
    }
    Console.WriteLine("Hour");
    var hourz = int.Parse(Console.ReadLine());
    if (hourz >= 6 && hourz <= 12 && daysToWeekend > 0)
    {
        Console.WriteLine($"Good morning, it is a lovely {dayOfWeek} today.There are {daysToWeekend} days to weekend");
    }
    else if (hourz >= 6 && hourz <= 12 && daysToWeekend <= 0)
    {
        Console.WriteLine($"Good morning, it is a lovely {dayOfWeek} today. The weekend is here");
    }
    else if (hourz <= 5 || hourz >= 13 && daysToWeekend > 0)
    {
        Console.WriteLine($"Good evening, it is a lovely {dayOfWeek} today. There are {daysToWeekend} days to weekend");
    }
    else if (hourz <= 5 || hourz >= 13 && daysToWeekend <= 0)
    {
        Console.WriteLine($"Good evening, it is a lovely {dayOfWeek} today. The weekend is here");
    }
}
catch (Exception)
{
    throw new Exception("error");
}
