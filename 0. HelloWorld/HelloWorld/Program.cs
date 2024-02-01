using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            //Variable Declarations & Initilization

            //byte userAge = 20;
            //int numberOfEmployees = 510;
            //double numberOfHours = 5121.5;
            //float hourlyRate = 60.5f;
            //decimal income = 25399.65m;
            //bool promote = true;
            //byte level = 2, userExperience = 5;

            //byte year; //declare the variable
            //year = 20; //initialize it

            // BASIC OPERATORS
            //int x = 7, y = 2;  -- Assignment
            //x + y;  -- Addition
            //x - y = 5; -- subtraction
            //x* y = 14;  -- Multiplication
            //x / y = 3(rounds down the answer to the nearest integer) -- Division
            //x % y = 1(gives the remainder when 7 is divided by 2) -- Modulus

            // ARRAYS
            //int[] userAge = { 21, 22, 23, 24, 25 };   -- Declaration and Initilization

            //int[] userAge = new int[5];  -- Declaration only for five items in the array userAge
            //userAge = new[] { 21, 22, 23, 24, 25 };  -- Initilization
            //Console.WriteLine(userAge[0]); // first element which is 21

            // Array properties and Methods
            //int[] userAge = new int[5];
            //userAge = new[] { 21, 22, 23, 24, 25 };

            // Length
            //userAge.Length();

            //Copy()
            //IndexOf()


            //STRINGS


            //Declaration and Initilization
            //string message = "Hello World";
            //string anotherMessage = ""; // empty string
            //string myName = "Evans," + "Kiprotich"; // concatenate/Joining of two strings using + sign

            // String Properties and Methods
            //Length message.Length
            //Substring --- message.Substring(2,5) resultimg to llo W
            //Equals() -- message.Equals(anotherMessage) -- either true or false
            //Split() -- example below
            //string[] separator = {", ", "; "};
            //string names = "Peter, John; Andy, , David";
            //string[] substrings = names.Split(separator,StringSplitOptions.None);
            // results of the above
            //{"Peter", "John", "Andy", "" , "David"}

            // LISTS

            // Declaring
            //List<int> userAgeList = new List<int>();

            // initilization
            //List<int> userAgeList = new List<int> { 11, 21, 31, 41 };
            //userAgeList[2]; //Accessing an element in a list

            // List Properties and Methods
            //Add()   -- userAgeList.Add(54); -- adds 54 to the list
            //Count   -- userAgeList.Count;  -- returns the total elements in that list
            //Insert() -- userAgeList.Insert(2,54); -- add 54 to position 3
            //Remove()  --userAgeList.Remove(54); -- removes 54 from the list
            //RemoveAt() -- userAgeList.RemoveAt(3) -- remove element at index 3
            //Contains() -- userAgeList.Contains(54);  -- checks if 54 is present in the list
            //Clear()  -- userAgeList.Clear();  -- rremoves or clears all the elements in the list

            // MAKING OUR PROGRAM INTERACTIVE

            //Displaying Messages to Users
            //Console.WriteLine("Hello ");
            //Console.WriteLine("How are you?");  -- Moves the cursor to the next line

            //we’ll get
            //Hello
            //How are you?

            //Console.Write("Hello ");
            //Console.Write("How are you?"); --- Writes everything on one line

            //we’ll get
            //Hello How are you?

            //Console.WriteLine("Hello, " + "how are you ?" + " I love C#."); --concatenate

            //int results = 79;

            //Console.WriteLine("You scored " + results + " Marks for your test.");
            //Console.WriteLine("{0}! You scored {1} marks for your test.", "Goodmorning", results);
            //Console.WriteLine("The number is {0:F3}.", 123.45678);  -- 3 decimal places F-specifier for numbers
            //Console.WriteLine("Deposit = {0:C}. Account balance = {1:C}.",2125, 12345.678);  C-Specifier formatting for currencies

            //Escape Sequence

            //Console.WriteLine("Hello\nWorld"); -- To prints a newline (\n)
            //Console.WriteLine("\\");  -- To print the backslash character itself (\\)
            //Console.WriteLine("I am 5'9\" tall");   -- To print double quotes (\”) so that the double quote does not end the string
            //Console.WriteLine("Hello\tWorld");  -- to print a tab, we type the backslash character before the letter t,like this: \t.

            // Accepting User Input
            //string userInput = Console.ReadLine();
            //Console.WriteLine(userInput);
            //string userInput = Console.ReadLine();
            //int newUserInput = Convert.ToInt32(userInput);  // Converting a String to a Number


            // Putting it all Together

            //string userName = "";
            //int userAge = 0;
            //int currentYear = 0;

            //Console.Write("Please Enter your name: ");
            //userName = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //userAge = Convert.ToInt32(Console.ReadLine());
            //Console.Write("please enter the current year: ");
            //currentYear = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in  {2}.", userName, userAge, currentYear - userAge);
            //Console.ReadLine();


            // Making Choices and Decisions

            // Condition Statements

            // == -- EQUAL TO -- (X == Y)
            // Not equal (!=)  -- 5 != 2 is true
            // Greater than (>)  -- 5 > 2 is true
            // Smaller than (<)  -- 1 < 7 IS TRUE
            // Greater than or equal to (>=) -- 3 >= 6 is false
            // Smaller than or equal to (<=)  -- 9 <= 6 is false

            // logical operators (&&, ||, !)

            // The AND operator (&&) -- Returns true if all conditions are met
            // ie 5==5 && 2<1 && 3!=7 is false as the second condition (2<1) is false

            // The OR operator (||)  -- Returns true if at least one condition is met
            // ie 5==5 || 2<1 || 3==7 is true as the first condition (5==5) is true 
            // 5==6 || 2<1 || 3== 7 is false as all conditions are false


            // Control Flow Statements

            // If Statement
            //int userAge;

            //Console.Write("Please enter your age: ");
            //userAge = Convert.ToInt32(Console.ReadLine());

            //if (userAge < 0 || userAge > 100)
            //{
            //    Console.WriteLine("Invalid Age");
            //    Console.WriteLine("Age must be between 0 and 100");
            //    Console.ReadLine();
            //}
            //else if (userAge < 18)
            //{
            //    Console.WriteLine("Sorry you are underage");
            //    Console.ReadLine();
            //}
            //else if (userAge < 21)
            //{
            //    Console.WriteLine("You need parental consent");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Congratulations!");
            //    Console.WriteLine("You may sign up for the event!");
            //    Console.ReadLine();
            //}


            // Inline If

            // syntax
            // condition ? value if condition is true : value if condition is false;

            // (3>2) ? 10 : 5; -- returns the value 10 since 3 is greater than 2



            // Switch Statement
            //The syntax of a switch statement is as follows:
            //switch (variable used for switching)
            //            {
            //case firstCase:
            //   do A;
            //break (or other jump statements);
            //case secondCase:
            //   do B;
            //break (or other jump statements);
            //case default:
            //   do C;
            //break (or other jump statements);
            //        }

            //Console.Write("Enter your grade: ");
            //string userGrade = Console.ReadLine();

            //switch (userGrade)
            //{
            //    case "A+":
            //    case "A":
            //        Console.WriteLine("Distinction");
            //        break;
            //    case "B":
            //        Console.WriteLine("B Grade");
            //        break;
            //        case "C":
            //        Console.WriteLine("C Grade");
            //        break;
            //        default:
            //        Console.WriteLine("Fail");
            //        break;
            //}

            // For Loop -- executes a block of code repeatedly until the test condition is no longer valid.

            // syntax
            //            for (initial value; test condition; modification to value)
            //{
            //                //Do Some Task
            //            }

            //for(int i =0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // Foreach Loop  -- when working with arrays and lists

            //char[] message = { 'H', 'e', 'l', 'l', 'o' };
            //foreach (char i in message)
            //    Console.Write(i);


            // While Loop  -- repeatedly executes instructions inside the loop while a certain condition remains valid.
            //            while (condition is true)
            //            {
            //                do A
            //}

            //int counter = 5;
            //while(counter > 0)
            //{
            //    Console.WriteLine("Counter = {0}", counter);
            //    counter = counter - 1;
            //}


            // Do while  -- the code within the curly braces of a do while loop is executed at least once.

            //int counter = 100;
            //do
            //{
            //    Console.WriteLine("Counter = {0}", counter);
            //    counter++;
            //} while (counter < 0);


            // Jump Statements  
            //A jump statement is a statement that instructs the program to deviate from its
            //normal flow sequence and jump to another line of code. Jump statements are
            //commonly used in loops and other control flow statements.


            // Break
            // The break keyword causes the program to exit a loop prematurely when a
            // certain condition is met.


            // Continue
            // When we use continue, the rest of the loop after the keyword is skipped for that iteration.

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("i = { 0}", i);
            //if (i == 2)
            //    continue;
            //Console.WriteLine("I will not be printed if i = 2.\n");


            // Exception Handling
            // try-catch-finally

            // syntax

            //            try
            //            {
            //                do something
            //}
            //            catch (type of error)
            //{
            //                do something else when an error occurs
            //}
            //finally
            //            {
            //                do this regardless of whether the try or catch condition is
            //                met.
            //                }

            //int numerator, denominator;
            //Console.Write("Please enter the numerator: ");
            //numerator = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the denominator: ");
            //denominator = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    Console.WriteLine("The result is {0}.", numerator / denominator);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("----End of Error Handling Example----");
            //}

            // Specific Errors

            //int choice = 0;
            //int[] numbers = { 10, 11, 12, 13, 14, 15 };
            //Console.Write("Please enter the index of the array: ");
            //try
            //{
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("numbers[{0}] = {1}", choice,
            //    numbers[choice]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index should be from 0 to 5.");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: You did not enter an integer.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


    }
    }
}
