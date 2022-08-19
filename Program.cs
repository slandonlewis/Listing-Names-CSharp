using System;
using System.Collections.Generic;

//Initial list of names

List<string> names = new List<string>()
{
    "Jordan Williams", "Travis Williams", "Dustin Dixon"
};

Console.WriteLine("");
Console.WriteLine("*** First Iteration ***");
Console.WriteLine("------------------------");

// Writes a greeting for each name on its own line

foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}");
}

// Added three more names

names.Add("Brittany Mangum");
names.Add("David Stewart");
names.Add("Sethward Theodosia Landon Elric Sebastian III");

Console.WriteLine("");
Console.WriteLine("*** Second Iteration ***");
Console.WriteLine("--------------------------");

// Only lists names longer than 20 characters

foreach (string name in names)
{
    if (name.Length > 20) {
        Console.WriteLine($"Hello, {name}");
    }
}