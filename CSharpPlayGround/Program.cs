/* See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
 */


//----------------------------------------------------Calculator
/*
Console.Write("Enter a Number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter another Number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Your total = " + (num1 + num2));

Console.ReadLine();
*/


//--------------------------------------------------BuildMadLibsGame
/*
string color, noun, celebrity;

Console.Write("Enter a color: ");
color = Console.ReadLine();

Console.Write("Enter a noun: ");
noun = Console.ReadLine();

Console.Write("Enter a celebrity: ");
celebrity = Console.ReadLine();


Console.WriteLine("Roses are " + color);
Console.WriteLine(noun + " are blue");
Console.WriteLine($"I love {celebrity}");

Console.ReadLine();
*/


//-------------------------------------------------------------Arrays
//a collection container of like variables
/*
int[] luckyNumbers = { 2, 4, 6, 8, 10 };
luckyNumbers[2] = 900;
string[] friends = new string[5];
friends[0] = "Jim";
friends[1] = "kelly";


Console.WriteLine($"hey "+friends[0]+" your lucky number is: "+luckyNumbers[2]);

Console.ReadLine();
*/


//-------------------------------------------------------------Methods
//reusable code you can call on with return values
/*
class Program
{
    static void Main(string[] args)
    {
        SayHi("Bob", 25);
            SayHi("John");
                SayHi("Mike");
                SayHi("");

        Console.WriteLine("Please enter the number you would like cubed: "); 
        int num = Convert.ToInt32(Console.ReadLine());
        //cant figure out unhandled exemption here when user enters string
        if (num * 1 == num)
        {
        Console.WriteLine($"your number cubed = " + cube(num)); 
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }


        Console.WriteLine("");      
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    static void SayHi(string name = "John Doe", int age = 0)
    {
        if (age == 0)
        {
            Console.WriteLine($"Hello {name}");
        }
        else
        {
            Console.WriteLine($"Hello {name}, you are {age} years old");
        }
    }
    static int cube(int num)
    {
        return num * num * num;
    }
}
*/


//-------------------------------------------------if statements
/*
class Program
{
    static void Main(string [] args)
    {
        bool isMale = true;
        bool isTall = false;

        if(isMale && isTall)
        {
            Console.WriteLine("You are a tall male");
        }
        else if (isMale && !isTall)
        {
            Console.WriteLine("You are a short male");

        }
         else if (!isMale && isTall)
        {
            Console.WriteLine("You are not a male but are tall");

        }
        else
        {
            Console.WriteLine("your gay");
        }
        Console.ReadLine();
        
    }
}
*/


//----------------------------------------------more if (compare method)
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetMax(5,2,8));
        Console.ReadLine();
    }
    static int GetMax(int num1, int num2, int num3)
    {
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        if (num3 > max)
        {
            max = num3;
        }
        return max;
    }

        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
       
    }
}
*/


//-------------------------------------------better calculator with if
/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator: ");
                string? op = Console.ReadLine();


                Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        else if (op == "-")
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        else if (op == "*")
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        else if (op == "/")
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }


        Console.ReadLine();
    }

}
*/


//-------------------------------Using switch statements instead of if
/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write(GetDay(80));
        Console.ReadLine();
    }

    static string GetDay(int dayNum)
    {
        string dayName;

        switch(dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }
        return dayName;
    }
}
*/


//---------------------------------------while loops guessing game
/*
class Program
{
    static void Main(string[] args)
    {
        string secretWord = "hello";
        string? guess = "";
        int numGuesses = 0;
        int guessLimit = 3;

        while (true)
        {
            Console.Write("Guess a Word: ");
            guess = Console.ReadLine();
            numGuesses++;
            if (numGuesses >= guessLimit)
            {
                Console.WriteLine("You lose");
                break;
            }
            else if (guess == secretWord)
            {
                Console.WriteLine("You win!");
                break;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        Console.ReadLine();
    }
}
*/

//--------------------------------------------







