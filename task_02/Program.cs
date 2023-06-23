Console.Write("Enter a day number: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfTheWeek == 1)
    Console.WriteLine("Monday");
else if (dayOfTheWeek == 2)
    Console.WriteLine("Tuesday");
else if (dayOfTheWeek == 3)
    Console.WriteLine("Wednesday");
else if (dayOfTheWeek == 4)
    Console.WriteLine("Thursday");
else if (dayOfTheWeek == 5)
    Console.WriteLine("Friday");
else if (dayOfTheWeek == 6)
    Console.WriteLine("Saturday");
else
    Console.WriteLine("Sunday");

// Experimental:

// string[] daysOfTheWeek =
// {
//     "Monday",
//     "Tuesday",
//     "Wednesday",
//     "Thursday",
//     "Friday",
//     "Saturday",
//     "Sunday"
// };
//
// if (dayOfTheWeek > 0 && dayOfTheWeek < 8)
//     Console.WriteLine(daysOfTheWeek[dayOfTheWeek - 1]);
// else
//     Console.WriteLine("Day of the week not found");
