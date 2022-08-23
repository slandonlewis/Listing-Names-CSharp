using System;
using System.Collections.Generic;

Console.WriteLine("");
Console.WriteLine("*** First Iteration ***");
Console.WriteLine("------------------------");

// Added three more names

// Console.WriteLine("");
// Console.WriteLine("*** Second Iteration ***");
// Console.WriteLine("--------------------------");

// Create and list new contact
Contact brittany = new Contact()
{
    Name = "Brittany Mangum",
    Email = "brittanymangum@gmail.com",
    Id = 1
};

Contact robert = new Contact()
{
    Name = "Robert Parker",
    Email = "robertparker@gmail.com",
    Id = 2
};

//Initial list of names
List<Contact> contacts = new List<Contact>()
{
    brittany, robert
};

// Writes a greeting for each name on its own line
foreach (Contact contact in contacts)
{
    Console.WriteLine($"Hello, {contact.Name}");
}

// Console.WriteLine($"{brittany.Name}, {brittany.Email}, {brittany.Id}");

// Contact class
public class Contact
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Id { get; set; }
}