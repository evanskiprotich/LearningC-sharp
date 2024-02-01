using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{

    // Access Modifiers Revisited
    // Access modifier is like a gate-keeper. It controls who has access to a certain field, property or method.
    // C# comes with 4 access modifiers: private, public, protected and internal.
    // Anything declared as internal is only accessible within the current assembly.

    class ClassA
    {
        private int privateNum = 1;
        public int publicNum = 2;
        protected int protectedNum = 3;
    }

    // If ClassB is derived from ClassA
    class ClassB : ClassA
    {
        public void PrintMessages()
        {
            //This is ok
            Console.WriteLine(publicNum);
            //This is ok
            Console.WriteLine(protectedNum);
            //This is NOT ok
            Console.WriteLine(privateNum);
        }
    }

    // the first two WriteLine() statements will not give us any error as a derived class can access any public and protected fields in the parent class.
    //However, the third statement gives us an error as privateNum is a private field and is thus only accessible in ClassA itself.

    //  If a class is not derived from ClassA, we need to instantiate a ClassA object in order to access the public field of ClassA.
    //  However, even with a ClassA object, we cannot access the private and protected fields of ClassA.

    class ClassC
    {
        ClassA a = new ClassA();
        public void PrintMessages()
        {
            //This is ok
            Console.WriteLine(a.publicNum);
            //This is NOT ok
            Console.WriteLine(a.protectedNum);
            //This is NOT ok
            Console.WriteLine(a.privateNum);
        }
    }

    // In short, anything that is declared as public is accessible everywhere; there are no restrictions on accessing public members.
    // On the other hand, anything declared as private is only accessible within the class in which it is declared.
    // Anything declared as protected is accessible within the class in which it is declared and any class that is derived from it.
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
