using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{

    // Abstract Classes and Methods

    // two special types of “parent class” in C# - abstract classes and interfaces

    // An abstract class is a special type of class that is created strictly to be a base class for other classes to derive from.
    // They cannot be instantiated.
    // Abstract classes may have fields, properties and methods just like any other classes.
    // However, they cannot have static members.
    // In addition, abstract classes can have a special type of method known as abstract methods.
    // Abstract methods are methods that have no body and MUST be implemented in the derived class.
    // They can only exist in abstract classes. In a way, an abstract method is like a contract.
    // If you want to ensure that any class that inherits your class implements a certain method, 
    // you can declare the class as an abstract class and the method as an abstract method.
    // To declare an abstract class, simply add the abstract keyword before the keyword class

    //abstract class MyClass
    //{
    //    // abstract method
    //    public abstract void MyAbstractMethod();
    //    // As abstract methods have no body, we end the declaration with a semi-colon (;).
    //}

    // To implement an abstract method in the derived class, we use the override keyword
    //public override void MyAbstractMethod()
    //{
    //}
    abstract class MyAbstractClass
    {
        private string message = "Hello C#";
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
        // method
        public abstract void PrintMessageAbstract();
    }

    // Inheritance
    class ClassA : MyAbstractClass
    {
        // override the method in MyAbstractClass
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyAbstractClass abClass = new MyAbstractClass();  -- you cannot intantiate an abstract class
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();
        }
    }
}