using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    // Object-Oriented Programming Part 1

    // an approach to programming that breaks a programming problem into objects that interact with each other.
    // Objects are created from templates known as classes. You can think of a class as the blueprint of a building.
    // An object is the actual “building” that we build based on the blueprint.


    // Writing our own class
    //    class Staff
    //{
    //    //Contents of the class
    //    //including fields, properties and methods
    //}

    class Staff
    {
        // Fields
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        // private in front of each declaration statement? 
        //This is known as an access modifier.Access modifiers are like gate keepers, 
        //theycontrol who has access to that field(i.e.who can read and modify the value of that field).

        //A field can either be private, public, protected or internal.
        // private. This means they can only be accessed from within the Staff class itself.
        // This is known as encapsulation. Encapsulation enables an object to hide data and
        // behaviour from other classes that do not need to know about them.
        // declaring a field as private is that we do not want otherclasses to freely modify them.
        // This helps to prevent the fields from being corrupted.


        // Properties
        // A property is commonly used to provide access to a private field in cases where the field is needed by other classes.
        // One of the main reasons is that using properties gives us greater control over
        // what rights other classes have when assessing these private fields

        //public int HoursWorked
        //{
        //    get
        //    {
        //        return hWorked;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //            hWorked = value;
        //        else
        //            hWorked = 0;
        //    }
        //}

        // The access modifier is public as we want other classes to have access to this property.
        // A property contains two special methods known as accessors. The first accessor is a getter and the second is a setter.


        // Auto-implemented Properties
        // To declare an auto-implemented property, we write
        // public int HoursWorked { get; set; }


        // Methods

        // A method is a code block that performs a certain task

        //public void PrintMessage()
        //{
        //    Console.WriteLine("Calculating Pay…");
        //}

        // The method declaration first states the accessibility level of the method. 
        // Here we declared the method as public so that the method is accessible everywhere in
        // the program(not just within the Staff class).

        // Next, we state the return type of the method. A method may return a certain result after performing its task.
        // If the method does not return any result, we use the void keyword

        // The parenthesis () after the method name is where we include the parameters of the method.
        // Parameters are names given to data that we pass in to the method in
        // order for it to perform its task.

        //public int CalculatePay()
        //{
        //    PrintMessage();
        //    int staffPay;
        //    staffPay = hWorked * hourlyRate;
        //    if (hWorked > 0)
        //        return staffPay;
        //    else
        //        return 0;
        //}

        // A method can access all the fields and properties that are declared inside the class. 
        // In addition, it can declare its own variables.These are known as local variables and only exist within the method.


        // Overloading

        // you can create two methods of the same name as long as they have different signatures.
        // This is known as overloading.
        // The signature of a method refers to the name of the method and the parameters that it has.

        //public int CalculatePay()
        //{
        //    PrintMessage();
        //    int staffPay;
        //    staffPay = hWorked * hourlyRate;
        //    if (hWorked > 0)
        //        return staffPay;
        //    else
        //        return 0;
        //}

        //public int CalculatePay(int bonus, int allowance)
        //{
        //    PrintMessage();
        //    if (hWorked > 0)
        //        return hWorked * hourlyRate + bonus + allowance;
        //    else
        //        return 0;
        //}

        // The signature of the first method is CalculatePay() while that of the second
        // method is CalculatePay(int bonus, int allowance).


        // The ToString() method

        // The ToString() method is a special method that returns a string that represents the current class

        //public override string ToString()
        //{
        //    return "Name of Staff = " + nameOfStaff + ", hourlyRate = " +
        //    hourlyRate + ", hWorked = " + hWorked;
        //}

        // the ToString() method returns a string type
        // The string that it returns contains information about the Staff class. 
        // The override keyword in the method declaration indicates that this method overrides the default method.



        // Constructors

        // A constructor is a special method that is used to ‘construct’ an object from the class template.
        // It is the first method that is called whenever we create an object from our class. 
        // Constructors are commonly used to initialize the fields of the class.
        // A constructor always has the same name as the class and does not return any value.
        // We do not need to use the void keyword when declaring a constructor.
        //public Staff(string name)
        //{
        //    nameOfStaff = name;
        //    Console.WriteLine("\n" + nameOfStaff);
        //    Console.WriteLine("--------------------------");
        //}

        // we can have more than one constructor as long as the signature is different
        //public Staff(string firstName, string lastName)
        //{
        //    nameOfStaff = firstName + " " + lastName;
        //    Console.WriteLine("\n" + nameOfStaff);
        //    Console.WriteLine("--------------------------");
        //}

        // Declaring a constructor is optional. If you do not declare your own constructor,
        // C# creates one for you automatically. The default constructor simply initializes
        // all the fields in the class to default values, which is normally zero for numeral
        // fields and empty string for string fields


        // Instantiating an Object


        // how we can make use of  the class to create an object. 
        // This process is known as instantiating an object. 
        // An object is also known as an instance.

        // RECAP

        // Fields
        //private const int hourlyRate
        //private string nameOfStaff
        //private int hWorked

        //Properties
        //public int HoursWorked

        //Methods
        //public void PrintMessage()
        //public int CalculatePay()
        //public int CalculatePay(int bonus, int allowance)
        //public override string ToString()

        //Constructors
        //public Staff(string name)
        //public Staff(string firstName, string lastName)

        // The syntax for instantiating an object is
        // ClassName objectName = new ClassName(arguments);

        // Staff staff1 = new Staff("Evans");
        // staff1.HoursWorked = 160;
        //pay = staff1.CalculatePay(1000, 400);
        //Console.WriteLine("Pay = {0}", pay);

        // Once we create the object, we can use the dot operator after the object’s name to
        // access any public field, property or method in the Staff class.

        // Note that we need to use the dot operator here as we are trying to access members of the Staff
        //class from the Program class. 
        // The dot operator is necessary whenever we want to access a field, property or method from another class.


        // Static Keyword

        // there are some classes or class members that can be accessed without the need to create any objects.
        // These are known as static classes or class members and are declared using the static keyword.

        // class MyClass
        // {
        // //Non static members
        // public string message = "Hello World";
        // public string Name { get; set; }
        // public void DisplayName()
        // {
        // Console.WriteLine("Name = {0}", Name);
        // }

        // //Static members
        // public static string greetings = "Good morning";
        // public static int Age { get; set; }
        // public static void DisplayAge()
        // {
        // Console.WriteLine("Age = {0}", Age);
        // }
        //            // To access the non static members of MyClass from another class, we need to instantiate an object as before:
        //            MyClass classA = new MyClass();
        //            Console.WriteLine(classA.message);
        //            classA.Name = "Jamie";
        //            classA.DisplayName();

        //                // However, to access the static members, we do not need to create any object. We simply use the class name to access them as shown below.
        //Console.WriteLine(MyClass.greetings);
        //            MyClass.Age = 39;
        //MyClass.DisplayAge();
        // } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
