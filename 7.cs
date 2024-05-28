Student.cs
Using System.ComponentModel.DataAnnotations;

Public class Student
{
    [Key]
    Public int Id { get; set; }

    Public string Name { get; set; }

    Public int Age { get; set; }
}
///////

AppDbContext.cs
Using Microsoft.EntityFrameworkCore;

Public class AppDbContext : DbContext
{
    Public DbSet<Student> Students { get; set; }

    Protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(“Data Source=students.db”);
    }
}
////
Program.cs

Using System;
Using System.Linq;

Class Program
{
    Static void Main(string[] args)
    {
        Using (var context = new AppDbContext())
        {
            // Create
            Var student = new Student { Name = “John”, Age = 20 };
            Context.Students.Add(student);
            Context.SaveChanges();
            Console.WriteLine(“Student added.”);

            // Read
            Var students = context.Students.ToList();
            Console.WriteLine(“Students:”);
            Foreach (var s in students)
            {
                Console.WriteLine($”Id: {s.Id}, Name: {s.Name}, Age: {s.Age}”);
            }

            // Update
            Var studentToUpdate = context.Students.First();
            studentToUpdate.Age = 25;
            context.SaveChanges();
            Console.WriteLine(“Student updated.”);

            // Delete
            Var studentToDelete = context.Students.First();
            Context.Students.Remove(studentToDelete);
            Context.SaveChanges();
            Console.WriteLine(“Student deleted.”);
        }
    }
}

