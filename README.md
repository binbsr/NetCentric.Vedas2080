# Please Note! these assignments are part of your final lab assessment report.
Manually create folders for each assignment under your repo root folder. 
1. Folder structure would be (Referring my repo, you use yours):
    ```
    > NetCentric.Vedas2080
        > ConsoleApp
        > Assignment 1
        > Assignment 2
        > ...
    ```
1. Save all your code snapshots in corresponding assignment folders. 

# Assignement 1

1. Create a new console application named **Greeter** under **Assignment 1** folder.
1. Modify **Program.cs** to define a variable **fullName** and assign some name.
1. Print value of **fullName** to console.
> Take a snapshot of your work here (Code + Output) and save it. 
4. Define another variable **cFullName** and initilize it with **fullName** in uppercase letters. (Hint: *ToUpper()* string helper)
1. Print value of **cFullName** to console in format: "Hello, BISHNU RAWAL Ji!"
> Take a snapshot of your work here (Code + Output) and save it. 
6. Instead of initilizing **fullName**, get it from user. (Hint: *Console.ReadLine()*)
> Take a snapshot of your work here (Code + Output) and save it. 
7. Now also ask user to enter his/her "Date of Birth" and display user friendly date to console. At this point your output should look like assuming user enters dob as "2010/12/12": (Hint: *DateTime.Parse(dateString)*)
```
Hello, BISHNU RAWAL Ji!
Your DOB: Sunday, 12 December 2010
```
> Take a snapshot of your work here (Code + Output) and save it. 
8. Your last task is to calculate his/her age as accurate as possible and dispaly it to console. (Hint: If you subract dob from current date, you will get TimeSpan value, TimeSpan will have properties like *.TotalDays*, *.TotalHours* etc.) End output will be like:
```
Hello, BISHNU RAWAL Ji!
Your DOB: Sunday, 12 December 2010
Age as of now: 13 Years 2 Months 1 Week 1 Day
```
# Assignment 2

Think of a real world scenario where you can design classe(s), interface(s) and members as shown in following class diagram:

![alt text](/Assignment%202/Assignment2.png)

> **Note:** Please create new console app to demonstrate all this and push your changes and snapshots (if needed) to respective assignment folder.