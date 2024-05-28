using System;
using System.IO;

class Program {
  static void Main() {
    // Prompt user to input the file path and read the input
    Console.Write("Input the file path: ");
    string filePath = Console.ReadLine();

    try {
      // Attempt to open the file using StreamReader within a using block for automatic resource disposal
      using(StreamReader reader = new StreamReader(filePath)) {
        // File opened successfully
        Console.WriteLine("File opened successfully.");
      }
    } catch (FileNotFoundException) {
      // Catch block for handling FileNotFoundException
      Console.WriteLine("Error: File not found.");
    } catch (IOException ex) {
      // Catch block for handling IOException while accessing the file
      Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
    } catch (Exception ex) {
      // Catch block for handling other types of exceptions
      Console.WriteLine("An unexpected error occurred: " + ex.Message);
    }
  }
}
