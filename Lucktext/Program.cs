string name; 


Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("skriv in ditt namn: ");
name = Console.ReadLine();

// Console.WriteLine("Hello " + "!");
Console.WriteLine($"Hello {name}!");

string age;

Console.WriteLine("skriv in hur gammal du är: ");
age = Console.ReadLine();

string city;

Console.WriteLine("vilken stad du bor i: ");
city = Console.ReadLine();

Console.WriteLine($"Hej jag heter {name} !");

Console.ReadLine();

















































