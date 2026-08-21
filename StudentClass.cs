using System;


public class Student
{
    public int Id { get;  set; }
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public DateTime DateOfBirth { get;  set; }
    public string Email { get;  set; }
    public string PhoneNumber { get;  set; }
    public DateTime RegisterDate { get;  set; }
    private static int NextId = 1;
    public Student() { }

    public Student(string name, string LName, DateTime dateOfBirth,
       string email, string phoneNumber)
    {
        FirstName = name;
        LastName = LName;
        DateOfBirth=dateOfBirth;
        Email=email;
        PhoneNumber=phoneNumber;

        Id = NextId;
        NextId++;
        RegisterDate = DateTime.Now;
    }
}