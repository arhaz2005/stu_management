using System.Collections.Concurrent;

StudentManager manager = new StudentManager();
bool flag = true;

while (flag)
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("1-Add student");
    Console.WriteLine("2-delete student by id");
    Console.WriteLine("3-Edit");
    Console.WriteLine("4-show the list");
    Console.WriteLine("5-search by name");
    Console.WriteLine("6-search by id");
    Console.WriteLine("7-order by age");
    Console.WriteLine("8-count");

    Console.WriteLine("0-exist");


    string answer = Console.ReadLine();
    switch (answer) {
        case "1":
            manager.AddStudent();
            break;

        case "2":
            manager.DeleteStudentById();
            break;

        case "3":
            Student selectedStudent = manager.SearchById();
            if (selectedStudent != null){
            selectedStudent.EditInfo();
            }
            break;

        case "4":
            manager.ShowAll();
            break;

        case "5":
            manager.SearchByName().ShowInfo();
            break;
            

        case "6":
            manager.SearchById().ShowInfo();
            break;

         case "7":
           List<Student> result = manager.OrderByAge();

          foreach (Student s in result)
           {
               s.ShowInfo();
           }
           break;

        case "8":
            Console.WriteLine("Count :");
            Console.WriteLine(manager.CountStudent());
            break;


        case "0":
            flag = false;
            break;

        default:
            Console.WriteLine("Invalid input!");
            break;
    }
}