Console.Write("Your Name? ");
string fullName = Console.ReadLine();

// dob
DateTime dob = default;
var parsingSuccess = false;
while (!parsingSuccess)
{
    Console.Write("Your DOB? ");
    string dobString = Console.ReadLine();
    parsingSuccess = DateTime.TryParse(dobString, out dob);
}

var ageOutput = GetAge(dob);
Console.WriteLine(ageOutput);

string cFullName = fullName.ToUpper();
//Console.WriteLine(fullName + "\n" + cFullName);
Console.WriteLine($"Noraml: {fullName} Capitalized: {cFullName}");

string GetAge(DateTime dob)
{
    TimeSpan age = DateTime.Now - dob;
    var ageIndDays = age.TotalDays;

    var years = (int)(ageIndDays / 365);
    var remainingDays = ageIndDays % 365;

    var months = (int)(remainingDays / 30);
    var remainingDaysAfterMonths = (int)(remainingDays % 30);

    var output = $"{years} Years {months} Months {remainingDaysAfterMonths} Days";
    return output;
}