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
class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 2, 4, 6, 8, 10 };
        luckyNumbers[2] = 900;
        string[] friends = new string[5];
        friends[0] = "Jim";
        friends[1] = "kelly";
        Console.WriteLine($"hey "+friends[0]+" your lucky number is: "+luckyNumbers[2]);
    }
}

 class Program
    {
        static void Main(string[] args)
        {
            int gameNum = 0;
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            Console.WriteLine("Welcome to the game store!");
            Console.Write("Enter a game number: ");
            gameNum = Convert.ToInt32(Console.ReadLine());
            if(gameNum < games.Length)
            {
                   Console.WriteLine($"You chose {games[gameNum]}");
            }
            else
            {
                Console.WriteLine("Invalid game number");
            }
          
            Console.ReadLine();
        }
    }
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

//--------------------------------------------for loop
/*
class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 4, 6, 8, 10, 20, 30, 40, 50, 100 };
        
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
        Console.ReadLine();
    }
}
*/


//--------------------------------------------Exponent calculator Function
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your power number: ");
        int powerNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The Exponent of {baseNum} , {powerNum} is: {GetPow(baseNum, powerNum)}");
        Console.ReadLine();
    }
    static int GetPow(int baseNum, int powerNum)
    {
        int result = 1;
        for (int i = 0; i < powerNum; i++)
        {
            result = result * baseNum;
        }
        return result;
    }
}
*/
//--------------------------------------------Social Network app
/*
 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Post: ");
            string? postText = Console.ReadLine();
            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
            Console.ReadLine();
        }
    }
    class Post
    {
        private string? text;
        public Post()
        {
            text = "";
        }
        public void ShowPost()
        {
            Console.WriteLine($"your new post reads: {text}");
        }
        
        public string? Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
    }
*/


//--------------------------------------------Arrays Grid element dimensions
/*
class Program
{
    static void Main(string[] args)
    {
        int[,] numberGrid = {
                                { 1, 2, 3 },
                                { 4, 5, 6 },
                                { 7, 8, 9 },
                                { 0, 0, 0 }
                            };
                            //int [,] myArray = new int[3, 3];
        Console.WriteLine(numberGrid[2, 2]);
        Console.ReadLine();
    }
}
*/


//--------------------------------------------catching exceptions
/*
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered {num}");
        }
        catch (FormatException fex)
        {
            Console.WriteLine("You did not enter a number");
        }
        catch (OverflowException oex)
        {
            Console.WriteLine("The number is too big");
        }
        finally
        {
            Console.WriteLine("Please press any key to exit");
            Console.ReadLine();
        }
    }
}
*/

//---------------------------classess && objects && constructors
/*
namespace CSharpPlayGround
{
    class Program //classess
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The C# Playground", "John Doe", 200); //constructors
            // book1.Title = "The C# Playground"; //objects
            // book1.Author = "John Doe";
            // book1.Pages = 200;
            Console.WriteLine($"{book1.Title} by {book1.Author} this book has {book1.Pages} pages");

            Book book2 = new Book("The F# Playground", "Jane Doe", 201); //constructors
            Console.WriteLine($"{book2.Title} by {book2.Author} this book has {book2.Pages} pages");
            
            Console.ReadLine();
        }
    }
}
*/

//--------------------------------------------Object Methods
/*
namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = "";
            double studentGPA = 0.0;
            string studentMajor = "";

            Console.WriteLine("Would you like to create a new student? (enter true or false)");
            bool createNewStudent = Convert.ToBoolean(Console.ReadLine());

            if (createNewStudent == true)
            {
                Student student1 = new Student(studentName, studentGPA, studentMajor);

            }
            else
            {
                Console.WriteLine("Exiting...");
                return;
            }
            //still needs work lol should loop until user exits
            Console.ReadLine();
        }
    }
}  
*/


////--------------------------------------------Getters and Setters (accessors and mutators)
/*
namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("The Matrix", "Wachowski", "PG", "Action");
            Console.WriteLine($"{movie1.name} is a {movie1.Rating} movie");
            Console.ReadLine();
        }
       
    }
}
*/


////--------------------------------------------Inheritance
/*
using System;
namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            //increment song count
            Song song1 = new Song("The Sign", "Ace of Base", 100);
            Console.WriteLine("{0} by {1} has {2} minutes, this song has been played {3} times", song1.Title, song1.Artist, song1.Duration, Song.Count);
            Song song2 = new Song("The Sign", "Ace of Base", 100);
            Console.WriteLine("{0} by {1} has {2} minutes, this song has been played {3} times", song1.Title, song1.Artist, song1.Duration, Song.Count);
            Console.ReadLine();
        }
    }
}
*/

////--------------------------------Static method and classess + Inheritance
/*
using System;
namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
           UsefulTools.SayHi("Rafael");
            Console.ReadLine();
        }
    }
}
*/


////--------------------------------------------Inheritance
using System;
namespace CSharpPlayGround //Chef.cs ItalianChef.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish(); //overrides the method in the base class
            Console.ReadLine();

        }
    }
}

