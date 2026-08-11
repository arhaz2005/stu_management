using System;

    
public class Student
{
    public int Id {get;private set;}
    public string FirstName {get; private set;}
    public string LastName {get; private set;}

    public DateTime DateOfBirth{get; private set;}
    private string Email;
    private string PhoneNumber;
    private DateTime RegisterDate;
    private static int NextId = 1;
 public Student(){    }

  public Student (string name,string LName, DateTime dateOfBirth,
     string email, string phoneNumber)
    {
        FirstName = name;
        LastName=LName;

        DateTime testDate = new DateTime(1950, 1, 1);
        if (dateOfBirth > testDate && dateOfBirth < DateTime.Now)
        {
            DateOfBirth = dateOfBirth;
        }
        else
        {
            DateOfBirth = testDate;
        }

        Email = email;

        if (phoneNumber.Length == 11)
        {
            PhoneNumber = phoneNumber;
        }
         else
        {
            PhoneNumber = "09123456789";
        }
        
        Id = NextId;
        NextId++;
        RegisterDate = DateTime.Now;

    }
    
    public DateTime SetDate(){
        int y,m,d;
        bool flagY,flagM,flagD;
        do
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("SET DATE");
            Console.WriteLine("Year:");
            flagY =int.TryParse(Console.ReadLine(), out y);
            
            Console.WriteLine("Month:");
            flagM =int.TryParse(Console.ReadLine(), out m);
        
            Console.WriteLine("day:");
            flagD =int.TryParse(Console.ReadLine(),out d);
        }while (!flagY || !flagM || !flagD);

        try{
          return new DateTime(y, m, d);
        }
        catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("error!");
                Console.WriteLine("out of range. 1950/1/1 has been saved!");
                return new DateTime(1950, 1, 1);
                 }
    }

    public void ShowInfo()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"full name: {FirstName}  {LastName}");
        Console.WriteLine($"date of birth: {this.DateOfBirth:yyyy/MM/dd}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Register date: {this.RegisterDate:yyyy/MM/dd}");
    }

    public void EditInfo(){
        Console.WriteLine("------------------dotnet run-EDIT----------------------");

        Console.WriteLine("for Edit enter the number:\n 1-name \n 2-date of birth \n 3-Email \n 4-phone number");
        string answer=Console.ReadLine();
        switch (answer)
        {
            case "1":
                Console.WriteLine("enter name:\n");
                string newName =Console.ReadLine();
                FirstName=newName;
                Console.WriteLine("enter Last name:\n");
                string LName =Console.ReadLine();
                LastName=LName;
                break;
            case "2":
                
                DateTime dateOfBirth= SetDate();
                DateTime testDate = new DateTime(1950, 1, 1);
                if (dateOfBirth > testDate && dateOfBirth < DateTime.Now)
               {
                   DateOfBirth = dateOfBirth;
                }
                else
                {
                   DateOfBirth = testDate;
                  }
                break;
                
            case "3":  
                Console.WriteLine("enter Email:\n");
                Email =Console.ReadLine();
                break;
            case "4":
                Console.WriteLine("enter phone numbar:\n");
                string phoneNumber =Console.ReadLine();    
                if (phoneNumber.Length == 11)
                  {
                   PhoneNumber = phoneNumber;
                   }
               else
                {
                  PhoneNumber = "09123456789";
                  }
                  break;
            default:
                break;
        }
    }

}