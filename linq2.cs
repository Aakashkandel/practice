using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int StudentId { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Create lists of students and courses
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alice" },
            new Student { StudentId = 2, Name = "Bob" },
            new Student { StudentId = 3, Name = "Charlie" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math", StudentId = 1 },
            new Course { CourseId = 102, CourseName = "Biology", StudentId = 2 },
            new Course { CourseId = 103, CourseName = "Physics", StudentId = 3 },
            new Course { CourseId = 104, CourseName = "Chemistry", StudentId = 1 }
        };

        // LINQ join to combine students and courses based on StudentId
        var result = from student in students
                     join course in courses on student.StudentId equals course.StudentId;
                     

        // Display the result
        Console.WriteLine("Joining Students and Courses:");
        foreach (var item in result)
        {
        Console.WriteLine(item);
        }
    }
}
