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
        Console.WriteLine("Show------------");
        foreach (Student student in students)
        {
            student.ShowInfo();
        }
    }
    
    public Student SearchById()
    {
        Console.WriteLine("enter id:");
        int id = int.Parse(Console.ReadLine());
        Student student = students.Find(s => s.Id == id);
        if (student != null)
        {
            return student;
        }
        else
        {
            Console.WriteLine("this Id not exist!");
            return null;
        }
    }

    
        public Student SearchByName()
    {
        Console.WriteLine("enter name:");
        string name = Console.ReadLine();
        Student student = students.Find(s => s.FullName == name);
        if (student != null)
        {
            return student;
        }
        else
        {
            Console.WriteLine("this name not exist!");
            return null;
        }
    }












}