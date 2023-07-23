using EntityFrameworkCoreExample;
using Microsoft.EntityFrameworkCore.Metadata;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
	FullName = "Johnny Test",
	EmailAddress = "FakeEmail@hotmail.com",
	DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new()
{
	FullName = "Jim Toast",
	EmailAddress = "FakeEmail@outlook.com",
	DateOfBirth = new DateTime(200, 1, 1)
};


dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.Students.Add(s2);
dbContext.SaveChanges(); // Executes an pending insert, update, and delete queries

// Retrieve Students from DB (SELECT)
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
	Console.WriteLine();
}