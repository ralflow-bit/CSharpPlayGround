namespace CSharpPlayGround
{
    public class NewStudent
    {
        public string? name { get; set; }
        public int? dob { get; set; }
        public string? prefIDE { get; set; }
        public double rateThisCouse { get; set; }
        public NewStudent(string Name, int DOB, string PrefIDE, double RateThisCourse)
        {
            Questions();
            PrintStudentInfo();
        } 
    
        public void PrintStudentInfo()
        {
            Console.WriteLine("-----New Student Record-----");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Prefered IDE: " + prefIDE);
            Console.WriteLine("Thank you for rating This Course a: " + rateThisCouse);
        }

        public void Questions()
        {
            Console.WriteLine("");
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Hello {name} what year were you born? ");
            dob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Which IDE do you Prefer VSCode or VS? ");
            prefIDE = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("From 1 to 5 with 5 being the best, how would rate this course? ");
            rateThisCouse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
        }   
        //  public bool RateThisCourse()
        // {
        //     if (rateThisCouse >= 3.5)
        //     {
        //         return true;
        //     }
        //     return false;
            
        // }
    }
}