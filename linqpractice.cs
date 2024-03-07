using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Faculty { get; set; }
}

public class Program
{
    public static void Main()
    {
        
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "aakash", Address = "daldale", Faculty = "Physics" },
            new Student { Id = 2, Name = "susant", Address = "gaindakot", Faculty = "Biology" },
            new Student { Id = 53, Name = "bijay", Address = "gaindakot", Faculty = "Chemistry" },
            new Student { Id = 455, Name = "rohit", Address = "gaindakot", Faculty = "Chemistry" },
            new Student { Id = 5, Name = "suman", Address = "gaindakot", Faculty = "Biology" }
        };

        
        var groupedResult = students
            .Where(student => student.Faculty == "Biology" || student.Faculty == "Chemistry")
            .GroupBy(student => student.Faculty);

        
        Console.WriteLine("Grouped by Faculty:");
        foreach (var group in groupedResult)
        {
            Console.WriteLine($"Faculty: {group.Key}");
            Console.WriteLine("Id\tName\tAddress");
            
            foreach (var student in group)
            {
                Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Address}");
            }
            
            int count = group.Count();
            Console.WriteLine($"Total Students in {group.Key}: {count}");
            Console.WriteLine();
        }
    }
}
