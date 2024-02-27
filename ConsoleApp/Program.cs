using System;

//Console.WriteLine(378);

DataTypes types = new();
types.LearnTypes();

Helpers h = new();
var bmi = h.CalculateBMI(5.10f);
var bmi2 = h.CalculateBMI(5.10f, 70);

(int youngest, int eldest) = h.GetYoungestAndEldest(2, 3, 4, 5, 6, 7, 8, 12, 1, 34, 45, 68, 17);

Generics<decimal> g = new();
g.Add(23.4f, 456.4f);
g.Add<int>(23, 456);
g.Add<string>("", "sasfasf");
g.Add<bool>(true, false);


var siddhartha = new Student();
siddhartha.Name = "Siddhartha Raut";
siddhartha.rollNumber = 23;
siddhartha.Email = "Siddhartha.Raut@gmail.com";

var deepak = new Student("Deepak Chaudhary", 12, "abc@abc.com", DateTime.Now);
var annayuna = new Student("", 10, "annayuna@abc.com");

siddhartha.PrintInfo();
deepak.PrintInfo();
annayuna.PrintInfo();

var rashmi = new CSStudent("Rashmi Mahato", 2, "rashmi@gmail.com", "Hospital Management System");
Console.WriteLine(rashmi.PrintInfo());


// LINQLearner l = new();
// l.Learn();