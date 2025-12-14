/*
/*
// string firstcommand = string.Empty;
// while ((firstcommand = Console.ReadLine()) != "end of contests")
// {
//     string[] contestPasswords = firstcommand
//         .Split(':');
//     string validContest = contestPasswords[0];
//     string validPassword = contestPasswords[1];
//
//     Console.WriteLine(validContest);
//     Console.WriteLine(validPassword);
// }


/*int[,] chessboard = new int[8, 8];

chessboard[0, 0] = 9;
chessboard[4, 3] = 34;

for (int row = 0; row < 8; row++)
{
    for (int col = 0; col < 8; col++)
    {
        Console.Write(chessboard[row, col] + " ");
    }

    Console.WriteLine();
}#2#


/*int[][] daysInMonths = new int[12][];

// Initialize each month with its corresponding number of days
daysInMonths[0] = new int[31]; // January
daysInMonths[1] = new int[28]; // February (non-leap year)
daysInMonths[2] = new int[31]; // March
daysInMonths[3] = new int[30]; // April
daysInMonths[4] = new int[31]; // May
daysInMonths[5] = new int[30]; // June
daysInMonths[6] = new int[31]; // July
daysInMonths[7] = new int[31]; // August
daysInMonths[8] = new int[30]; // September
daysInMonths[9] = new int[31]; // October
daysInMonths[10] = new int[30]; // November
daysInMonths[11] = new int[31]; // December

// Print the number of days in each month
for (int month = 0; month < daysInMonths.Length; month++)
{
    Console.WriteLine($"Month {month + 1}: {daysInMonths[month].Length} days");
}#2#

////////////////////////////////////////////

FIND ELEMENT IN A COLLECTION IF THIS COLLECTION IS A VALUE IN A DICTIONARY

public class Program
{
    public static void Main()
    {
        var dictionary = new Dictionary<string, List<string>>
        {
            { "GroupA", new List<string> { "Alice", "Bob" } },
            { "GroupB", new List<string> { "Charlie", "David" } },
            { "GroupC", new List<string> { "Eve" } }
        };

        string targetElement = "David";
        string foundKey = FindKeyByElement(dictionary, targetElement);

        if (foundKey != null)
        {
            Console.WriteLine($"Found '{targetElement}' under the key: {foundKey}");
        }
        else
        {
            Console.WriteLine($"'{targetElement}' was not found in any list.");
        }
    }

    // A reusable method to search the dictionary
    public static string FindKeyByElement(Dictionary<string, List<string>> dict, string element)
    {
        // Iterate through every KeyValuePair in the dictionary
        foreach (var keyValuePair in dict)
        {
            // keyValuePair.Value gives us the inner List<string>
            if (keyValuePair.Value.Contains(element))
            {
                // If the inner list contains the element, return the corresponding key
                return keyValuePair.Key;
            }
        }

        // If the loop finishes without finding the element, return null
        return null;
    }
}

OR USE LINQ :

var foundKeyLinq = dictionary
   .Where(kvp => kvp.Value.Contains(targetElement)) // Filter pairs where value matches
   .Select(kvp => kvp.Key)                          // Select only the key
   .FirstOrDefault();
#1#



var names = new string[]
{
    "Tony", "Clint", "Bob", "Alice", "Lisa"
};

var name = names.ElementAtOrDefault(5);
Console.WriteLine(name ?? "Name not found.");
*/


// var myList = new List<string> { "Apple", "Banana", "Cherry", "Banana" };
//
// foreach (var item in myList)
// {
//     if (item == "Banana")
//     {
//         myList.Remove(item); // Throws InvalidOperationException
//     }
// }


/*
var fruits = new List<string> { "Apple", "Banana", "Cherry", "Banana" };

for (int i = 0; i < fruits.Count; i++)
{
    if (fruits[i] == "Banana")
    {
        fruits.RemoveAt(i);
        // Adjust the index to account for the removed item
        i--; 
    }
}
Console.WriteLine(string.Join(", ", fruits)); 
// Output: Apple, Cherry
*/


// var originalList = new List<string> { "Apple", "Banana", "Cherry", "Banana" };
//
// foreach (var item in originalList.ToList()) // Create a copy
// {
//     if (item == "Banana")
//     {
//         originalList.Remove(item); // Safe removal
//     }
// }
// Console.WriteLine(string.Join(", ", originalList)); 
// // Output: Apple, Cherry



// var fruits = new List<string> { "Apple", "Banana", "Cherry", "Banana" };
//
// fruits = fruits.Where(item => item != "Banana").ToList(); // Filter out "Banana"
//
// Console.WriteLine(string.Join(", ", fruits)); 
// // Output: Apple, Cherry


