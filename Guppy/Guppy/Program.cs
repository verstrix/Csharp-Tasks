/*DateTime now = DateTime.Now;
Console.WriteLine(now.ToString("F"));
Console.WriteLine("Enter years to add to the current one");
var year = now.Year + int.Parse(Console.ReadLine());
Console.WriteLine($"After 10 years: {year}");
*/

DateTime now = DateTime.Now;
Console.WriteLine("How old are you: "); 
var currentAge = Console.ReadLine();
Console.WriteLine("How old you want to be: ");
var futureAge = Console.ReadLine();
Console.WriteLine("On which month have u been born: ");
var month = int.Parse(Console.ReadLine());
Console.WriteLine("On which day have u been born: ");
var day = int.Parse(Console.ReadLine());
var year = now.Year - int.Parse(currentAge);

Console.WriteLine($"You were born on {day} day {month} month {year} year");
var germanYears = Convert.ToInt32(futureAge);
var polishInvasion = Convert.ToInt32(currentAge);
var theThirdReichYears = germanYears - polishInvasion;
var neoNacistYears = now.Year + theThirdReichYears;
Console.WriteLine($"At {neoNacistYears} you will be {germanYears}");