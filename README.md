# Please Note! these assignments are part of your final lab assessment report.
1. Lab report document layout:
    1. Assignment N (Related Area)
        ```
        Assignment Description
        ```
    1. Implementation
        ```
        Relevant Code Sections Only
        ```
    1. Output Snapshots
        ```
        Attach snapshots taken during code execution
        ```
1. Manually create folders for each assignment under your repo root folder. Folder structure would be (Referring my repo, you use yours):
    ```
    > NetCentric.Vedas2080
        > ConsoleApp
        > Assignment 1
        > Assignment 2
        > ...
    ```
1. Save all your code snapshots in corresponding assignment folders. 

# Assignement 1 (Starter)

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
# Assignment 2 (OOP Concepts)

Think of a real world scenario where you can design classe(s), interface(s) and members as shown in following class diagram:

![alt text](/Assignment%202/Assignment2.png)

> **Note:** Please create new console app to demonstrate all this and push your changes and snapshots (if needed) to respective assignment folder.

# Assignment 3 (File Handling and LINQ)

You have csv data for inflation rate in Asia and the Pacific: `Assignment 3\Inflation.csv`. 
RegionalMember | Year |Inflation|Unit of Measurement| Subregion| Country Code|
--------|-------|------|------|------|-------------------------------------------
........|........|....|....|.......|..........
Armenia|	2022	|8.6|	%|	Central Asia|	ARM|
Armenia	|2023|	7|	%|	Central Asia|	ARM
Armenia	|2024|	6.2|	%|	Central Asia|	ARM
Azerbaijan|	2018|	2.4|	%|	Central Asia|	AZE
Azerbaijan|	2019|	2.7|	%|	Central Asia|	AZE
Azerbaijan|	2020|	2.8|	%|	Central Asia|	AZE
........|........|....|....|.......|..........

Now your tasks:
1. Create class **Inflation** with all column headers in csv file as properties.
2. Create another class **InflationAnalysis** with methods as needed to
    1. Read csv text file and populate `List<Inflation>` collection with the data read.
    2. To answer following queries related to inflation
        1. Find inflation rates for countries for the year 2021.
        2. A year when Nepal has highest inflation.
        3. List top 10 regions (countries) where inflation is highest for all time
        4. List top 3 south asian countries with lowest inflation rate for year 2020

> Note: Take snapshots as needed for your attempt progress (Code + Output).

# Assignment 3 (ASP .NET Core MVC)
# Student Management System

## Task 1: Setting Up the Project

    1. Create a new ASP.NET Core MVC project.
    2. Install necessary NuGet packages for SQLite (Microsoft.EntityFrameworkCore.Sqlite) and API calls (System.Net.Http.Json).
    3. Set up SQLite database context for student management.

## Task 2: Create Models

    1. Create a Student model with properties like Id, Name, Email, and Age.
    2. Add data annotations for field validations (e.g., Required, EmailAddress, Range).

## Task 3: Create Views

    1. Create views for listing all students, creating a new student, editing a student, and deleting a student.
    2. Implement form validation on the views using Razor syntax and client-side validation.

## Task 4: Implement CRUD Operations

    1. Create: Add a new student to the database.
    2. Read: Retrieve a list of all students and display them on the index page.
    3. Update: Edit existing student details.
    4. Delete: Remove a student from the database.

## Task 5: API Integration

    1. Create a separate controller for API calls to fetch student data.
    2. Implement API endpoints for CRUD operations to interact with student data using HTTP methods (GET, POST, PUT, DELETE).

## Task 6: Testing

    1. Test the application by adding, editing, and deleting student records from the views.

## Task 7: Authentication and Authorization

    1. Implement authentication and authorization mechanisms to control access to the student management system.

> Note: Take snapshots as needed for your attempt progress (Code + Output).

