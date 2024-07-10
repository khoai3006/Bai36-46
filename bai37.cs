using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("\nStudent Management System");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Display student list");
            Console.WriteLine("3. Calculate total score");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    DisplayStudents(students);
                    break;
                case 3:
                    CalculateTotalScore(students);
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddStudent(List<Student> students)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student grade: ");
        double grade = double.Parse(Console.ReadLine());

        students.Add(new Student { Name = name, Grade = grade });
        Console.WriteLine("Student added successfully.");
    }

    static void DisplayStudents(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the list.");
            return;
        }

        Console.WriteLine("\nList of students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
        }
    }

    static void CalculateTotalScore(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the list.");
            return;
        }

        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Grade;
        }

        Console.WriteLine($"Total score of all students: {totalScore}");
    }
}