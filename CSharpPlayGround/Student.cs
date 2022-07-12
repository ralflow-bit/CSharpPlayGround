using System;
namespace CSharpPlayGround
{
    public class Student
    {
        public string? name { get; set; }
        public double? gpa { get; set; }
        public string? major { get; set; }
        public Student(string Name, double GPA, string Major)
        {
            name = Name;
            gpa = GPA;
            major = Major;
            Console.WriteLine("PLease Create new student");
          
            Console.WriteLine("Enter your name: ");
            string? studentName = Console.ReadLine();
            Console.WriteLine("Enter your GPA: ");
            double studentGPA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Major ");
            string? studentMajor = Console.ReadLine();
            Console.WriteLine(studentName + " has a GPA of " + studentGPA + " and is majoring in " + studentMajor);
            Console.WriteLine("A New Student has been created, press enter to exit ");
        }
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
            
        }
    }
}