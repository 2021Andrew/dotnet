using System;

class Program
{
    static void Main()
    {
        // Define an integer array
        int[] b = { 5, 4, 6, 6 };

        // Define a string array
        string[] strArray = { "Hello", "World", "CSharp", "Programming" };

        // Loop through each element in the integer array and print
        Console.WriteLine("Integer array elements:");
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
        }

        // Perform various string experiments
        Console.WriteLine("\nString array elements:");
        for (int i = 0; i < strArray.Length; i++)
        {
            Console.WriteLine(strArray[i]);
        }

        // String concatenation
        string concatenated = string.Join(" ", strArray);
        Console.WriteLine("\nConcatenated string: " + concatenated);

        // Find length of each string
        Console.WriteLine("\nLength of each string:");
        foreach (string str in strArray)
        {
            Console.WriteLine($"Length of '{str}': {str.Length}");
        }

        // Substring extraction
        Console.WriteLine("\nSubstring extraction:");
        foreach (string str in strArray)
        {
            if (str.Length > 3)
            {
                Console.WriteLine($"First 3 characters of '{str}': {str.Substring(0, 3)}");
            }
        }

        // Convert to uppercase
        Console.WriteLine("\nUppercase conversion:");
        foreach (string str in strArray)
        {
            Console.WriteLine($"Uppercase of '{str}': {str.ToUpper()}");
        }

        // Convert to lowercase
        Console.WriteLine("\nLowercase conversion:");
        foreach (string str in strArray)
        {
            Console.WriteLine($"Lowercase of '{str}': {str.ToLower()}");
        }

        // Check if string contains a specific substring
        string substring = "Sharp";
        Console.WriteLine($"\nCheck if strings contain '{substring}':");
        foreach (string str in strArray)
        {
            bool contains = str.Contains(substring);
            Console.WriteLine($"'{str}' contains '{substring}': {contains}");
        }

        // Wait for the user to press Enter before closing the console window
        Console.ReadLine();
    }
}
