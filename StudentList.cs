using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;


public class StudentManager
{
    List<Student> students = new List<Student>();

    public void AddStudent()
    {
        string name, LName, number, email;
        DateTime dateOfBirth;
        Console.WriteLine("-------------ADD STUDENT-----------");

        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        LName = Console.ReadLine();

        Student s = new Student();

        dateOfBirth = s.SetDate();

        Console.WriteLine("enter email:");
        email = Console.ReadLine();

        Console.WriteLine("enter phone number:");
        number = Console.ReadLine();

        Student student = new Student(name, LName, dateOfBirth, email, number);
        students.Add(student);
    }

    public void ShowAll()
    {
        Console.WriteLine("-------------------SHOW--------------------");
        foreach (Student student in students)
        {
            student.ShowInfo();
        }
    }

    public Student SearchById()
    {
        Console.WriteLine("---------------SEARCH BY ID-----------------");
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
        Console.WriteLine("---------------SEARCH BY NAME-----------------");

        Console.WriteLine("enter last name:");
        string name = Console.ReadLine();
        Student student = students.Find(s => s.LastName == name);
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

    public void DeleteStudentById()
    {
        Console.WriteLine("---------------DELETE BY ID-----------------");

        Console.WriteLine("enter id:");
        int id = int.Parse(Console.ReadLine());
        Student student = students.Find(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("deleted!");
        }
        else
        {
            Console.WriteLine("id not exist!");
        }
    }

    public List<Student> OrderByAge()
    {
        Console.WriteLine("---------------ORDER BY AGE-----------------");

        List<Student> copy = students.ToList();
        List<Student> result = new List<Student>();
        int index = CountStudent();
        for (int i = 0; i < index; i++)
        {
            Student MaxAge = copy[0];
            foreach (Student s2 in copy)
            {
                if (s2.DateOfBirth < MaxAge.DateOfBirth)
                {
                    MaxAge = s2;
                }
            }
            result.Add(MaxAge);
            copy.Remove(MaxAge);
        }
        return result;
    }

    public List<Student> OrderByName()
    {
        Console.WriteLine("---------------ORDER BY NAME-----------------");
        List<Student> copy = students.ToList();
        List<Student> result = new List<Student>();

        int index = copy.Count;

        for (int i = 0; i < index; i++)
        {
            Student firstName = copy[0];

            foreach (Student s in copy)
            {
                if (string.Compare(s.LastName, firstName.LastName) < 0)
                {
                    firstName = s;
                }
            }

            result.Add(firstName);
            copy.Remove(firstName);
        }

        return result;
    }

    public int CountStudent()
    {
        Console.WriteLine("---------------COUNT-----------------");

        int c = 0;
        foreach (Student s in students)
        {
            c++;
        }
        return c;
    }

    public void TestAdd()
    {
        DateTime d1 = new DateTime(2005, 08, 05);
        Student s1 = new Student("zahra", "safari", d1, "arhaz@gmail.com", "09123456789");
        students.Add(s1);

        DateTime d2 = new DateTime(2000, 10, 29);
        Student s2 = new Student("reza", "rezaee", d2, "reza@gmail.com", "09145678765");
        students.Add(s2);


        DateTime d3 = new DateTime(1990, 11, 16);
        Student s3 = new Student("ali", "some", d3, "ali@gmail.com", "09123456789");
        students.Add(s3);


        DateTime d4 = new DateTime(1999, 01, 20);
        Student s4 = new Student("mahsa", "some ", d4, "wrong@gmail.com", "09123456789");
        students.Add(s4);
    }

}

