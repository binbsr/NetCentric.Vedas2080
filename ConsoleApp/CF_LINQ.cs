// LINQ - Language INtegrated Query

using System;
using System.Collections.Generic;
using System.Linq;

class LINQLearner
{
    public void Learn()
    {
        int[] numbers = [3, 5, 6, 7, 34, 56, 78, 89, 234];
                
        List<Student> students = 
        [
            new Student("Ram Shrestha", 12, "ram@gmail.com"),
            new Student("Reema Shrestha", 10, "Reema@gmail.com"),
            new Student("Sita Aryal", 1, "Sita@gmail.com"),
            new Student("Sandeep Maharjan", 2, "Sandeep@abc.com"),
            new Student("Bishnu Rawal", 20, "bishnu@live.com")
        ];

        var squares = numbers.Select(number => number * number);
        var evenNumbers = numbers.Where(number => number % 2 == 0);

        // Find cubes of all odd numbers with in "numbers"
        // Method syntax
        var cubes = numbers.Where(num => num % 2 == 1).Select(num => Math.Pow(num, 3));

        // Expression syntax
        cubes = from num in numbers
                where num % 2 == 1
                select Math.Pow(num, 3);
        
        // Find students with roll number less than 50 and order them by name in ascending order
        var verifiedStudents = students
            .Where(student => student.rollNumber < 50)
            .OrderBy(s => s.Name);

        // Group all students by email domain
        var studentGroups = students.GroupBy(st => st.Email[(st.Email.IndexOf('@') + 1)..]);

        foreach(var studentGroup in studentGroups)
        {
            Console.WriteLine($"Domain Name: {studentGroup.Key}");
            foreach(var student in studentGroup)
            {
                Console.WriteLine($"\t\t{student.PrintInfo()}");
            }
        }

    }
}