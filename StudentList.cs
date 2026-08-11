using System;
using System.Collections.Generic;
using System.Linq;


public class StudentManager
{
    List<Student> students = new List<Student>();
    public void AddStudent()
    {
        string name, number, email;
        DateTime dateOfBirth;
        Console.WriteLine("ADD STUDENT-----------");

        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
        Student s = new Student();
        dateOfBirth = s.SetDate();

        Console.WriteLine("enter email:");
        email = Console.ReadLine();

        Console.WriteLine("enter phone number:");
        number = Console.ReadLine();

        Student student = new Student(name, dateOfBirth, email, number);
        students.Add(student);
    }

        public void ShowAll()
    {
        Console.WriteLine("Show------------")
        foreach (Student student in students)
        {
            student.ShowInfo();
        }
    }













}