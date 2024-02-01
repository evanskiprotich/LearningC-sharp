using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    // Enum
    // An enum (which stands for enumerated type) is a special data type that allows programmers to provide meaningful names for a set of integral constants.
    //To declare an enum, we use the enum keyword followed by the name of the enum. 
    //The members of the enum are enclosed in a set of curly braces and separated by commas.

    //enum DaysOfWeek
    //{
    //    Sun, Mon, Tues, Wed, Thurs, Fri, Sat
    //}
    // Initilizing
    //DaysOfWeek myDays = DaysOfWeek.Mon;
    //Console.WriteLine(daysOfWeek);

    // By default, each member in the enum is assigned an integer value, starting from zero.
    // As members of an enum are essentially integers
    //Console.WriteLine((int)myDays);  -- gives us the integer 1 while
    //Console.WriteLine((DaysOfWeek)1); -- gives us Mon

    // If you want to assign a different set of integers to your enum members, you can do the following
    //enum DaysOfWeekTwo
    //{
    //    Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat
    //}

    //Now, Sun is assigned a value of 5 and Mon is assigned 10. As we did not assign
    //values for Tues to Sat, consecutive numbers after 10 will be assigned to them.
    //That is Tues = 11, Wed = 12 and so on.

    // All enums are stored internally as integers (int). If you want to change the
    // underlying data type from int to another data type, you add a colon after the
    //enum name, followed by the desired data type.Any integer data type is allowed
    //except for char.

    //enum DaysOfWeekThree : byte
    //{
    //    Sun, Mon, Tues, Wed, Thurs, Fri, Sat
    //}


    // Struct


    // A struct is similar to a class in many aspects. 
    //Like classes, they contain elements like properties, constructors, methods and fields and allow you to group related
    //members into a single package so that you can manipulate them as a group.

    // To declare a struct, you use the struct keyword
    struct MyStruct
    {
        // Fields
        private int x, y;
        private AnotherClass myClass;
        private Days myDays;

        // Constructor
        public MyStruct(int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = myDays.Mon;
        }

        // Method
        public void PrintStatement()
        {
            Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y,myDays);
        }
    }

    //There are two main differences between a struct and a class
    //Firstly, the struct data type does not support inheritance.Hence you cannot derive one struct from another.
    //However, a struct can implement an interface. The way to do it is identical to how it is done with classes.
    //The second difference between structs and classes is that structs are value types while classes are reference types

    class AnotherClass
    {
        public int number;
    }

    enum Days { Mon, Tues, Wed }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct example = new MyStruct(2, 3, 5);
            example.PrintStatement();
        }
    }
}
