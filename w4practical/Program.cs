
// car manufacturers array

using System.ComponentModel.DataAnnotations;
using w4practical;

string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

    foreach (string manufacturer in carManufacturers)
    {
        Console.WriteLine(manufacturer);
    }

    Array.Sort(carManufacturers);

Console.WriteLine("\nSorted car manufacturers:\n");

foreach (string manufacturer in carManufacturers)
{
    Console.WriteLine(manufacturer);
}

try
{
    Console.WriteLine("");

    for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++) // <= cause index out of bounds exception
    {

        Console.WriteLine($"Car manufacturer at index {carIndex}: {carManufacturers[carIndex]}");
    }
}

catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"\nError: Attempted to access an array index that does not exist.");
}

finally
{
    Console.WriteLine("Array processing complete.");
}

// months list

List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

Console.WriteLine("\nNumber of months: {0}\n", months.Count);

months.Remove("September");
months.Remove("November");

Console.WriteLine("Number of months after removal: {0}", months.Count);

Console.WriteLine("\nIndex of December: {0}", months.IndexOf("December"));

string[] monthNamesArray = months.ToArray();

// dictionary inventory

Dictionary<string, int> inventory = new Dictionary<string, int>();
inventory.Add("Health potion", 5);
inventory.Add("Mana potion", 2);
inventory.Add("Gold coin", 100);

Console.WriteLine("\nInventory:");
Console.WriteLine("Health potion: {0}", inventory["Health potion"]);
Console.WriteLine("Mana potion: {0}", inventory["Mana potion"]);
Console.WriteLine("Gold coin: {0}", inventory["Gold coin"]);

inventory["Health potion"] = 20; // update value for existing key
Console.WriteLine("\nUpdated inventory:");
// Console.WriteLine($"Health potion: {inventory["Health potion"]}"); alternative way
Console.WriteLine("Health potion: {0}", inventory["Health potion"]);

try
{
    Console.WriteLine("Iron sword: {0}", inventory["Iron sword"]); // will throw keynotfoundexception because key does not exist in dictionary
}

catch (KeyNotFoundException ex)
{
    Console.WriteLine($"\nError: Item not found in inventory.");
}

finally
{
    Console.WriteLine("Inventory processing complete.\n");
}

Student student1 = new Student(1, "Alice Smith", 20);

List<Student> students = new List<Student>();
students.Add(student1);

Student student2 = student1; // reference copy of student1

student2.Age = 99; // changing age of student2 will also change age of student1 because they reference the same object

student1.Display();