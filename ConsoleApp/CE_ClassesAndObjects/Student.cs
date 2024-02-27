using System;

class Student
{
    // Default construtor
    public Student()
    {

    }
    // Parameterized constructor
    public Student(string n, byte rn, string e)
    {
        name = n;
        rollNumber = rn;
        Email = e;
    }
    public Student(string n, byte rn, string e, DateTime dob) : this(n, rn, e)
    {
        Dob = dob;
    }

    string name;
    // Full property definition
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length >= 2)
            {
                name = value;
            }
        }
    }
    public byte rollNumber;
    public DateTime Dob { get; }
    
    // Auto implemented property
    public string Email { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student Roll Number: {rollNumber}");
        Console.WriteLine($"Student Dob: {Dob}");
        Console.WriteLine($"Student Email: {Email}");
    }
}
