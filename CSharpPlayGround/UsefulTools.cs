using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace CSharpPlayGround
{
    class UsefulTools
    {
        public static void SayHi(string? name)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("");
        }
        public static void SayBye(string? name)
        {   
                        Console.WriteLine("");   
            Console.WriteLine("________________________________________________________________");   
                         Console.WriteLine("");   
            Console.WriteLine("***Please open up the Program.cs file and see what I have done.");
            Console.WriteLine("Comment out the code in the Program.cs file and see what happens.");
            Console.WriteLine("Good Bye and thank you for visiting my CSharp repo*** " + name);
            Console.WriteLine("________________________________________________________________");     
            Console.Write("Press return to exit: ");
            Console.ReadLine();
                        Console.WriteLine("");
        }
          public static void SayWelcome()
        {
                        Console.WriteLine("");
            Console.WriteLine("Hello and welcome to my CSharp for Begginners Note Pad!");
                        Console.WriteLine("");
            Console.WriteLine("I hope you find the information here helpful on your journey to becoming an awesome developer.");
                        Console.WriteLine("");
            Console.Write("My name is LightningBits, What's Yours? ");
                        Console.WriteLine("");
        }
    }
}
