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

    public virtual string PrintInfo()
    {
        var studentInfo = $"Student Name: {Name}, Roll Number: {rollNumber}, Dob: {Dob}, Email: {Email}";
        return studentInfo;
    }
}
