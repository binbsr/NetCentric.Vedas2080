using System;

class DataTypes
{    
    public void LearnTypes()
    {
        // Strongly typed (static) vs weakly typed (dynamic)

        // Numbers
        byte age = 255;
        short numberOfStudents = 3242;  //Camel casing vs pascal casing
        int population = 343234534;
        long distance = 342342424201;

        float a = 23.489798798788786f;
        double b = 32424.23424427987897897;
        decimal c = 234423.35353534535353534m;

        // Texts
        char initial = 'M';
        string name = "sdsdf sdfsdfsf";

        bool isMale = true;

        DateTime dob = DateTime.Now;

        Console.WriteLine(dob);
    }
}