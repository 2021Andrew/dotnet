multiple forms
Form1.cs
Using System;

Public class Form1
{
    Public void Show()
    {
        Console.WriteLine(“Form1 is open.”);
        Console.WriteLine(“Press Enter to open Form2.”);
        Console.ReadLine();

        // Open Form2
        Form2 form2 = new Form2();
        Form2.Show();

        // Wait for Form2 to close
        Console.WriteLine(“Form2 is closed.”);
        Console.WriteLine(“Press Enter to exit Form1.”);
        Console.ReadLine();
    }
}

Form2.cs

Using System;

Public class Form2
{
    Public void Show()
    {
        Console.WriteLine(“Form2 is open.”);
        Console.WriteLine(“Press Enter to close Form2.”);
        Console.ReadLine();
    }
}

Finally.cs
Using System;

Class Finally
{
    Static void Main(string[] args)
    {
        Form1 form1 = new Form1();
        Form1.Show();
    }
}

