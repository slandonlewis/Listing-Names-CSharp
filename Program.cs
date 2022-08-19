using System;
using System.Collections.Generic;

List<string> names = new List<string>()
{
    "Jordan Williams", "Travis Williams", "Dustin Dixon"
};

Console.WriteLine("");
Console.WriteLine("*** First Iteration ***");
Console.WriteLine("------------------------");

foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}");
}

names.Add("Brittany Mangum");
names.Add("David Stewart");
names.Add("Sethward Theodosia Landon Elric Sebastian III");

Console.WriteLine("");
Console.WriteLine("*** Second Iteration ***");
Console.WriteLine("--------------------------");

foreach (string name in names)
{
    if (name.Length > 20) {
        Console.WriteLine($"Hello, {name}");
    }
}