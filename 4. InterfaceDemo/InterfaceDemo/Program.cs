using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    // Interfaces

    // Interfaces are much like abstract classes in that they cannot be instantiated and must be inherited.
    // interfaces are more conceptual than abstract classes.They can only contain methods with no bodies.
    // In addition, they cannot contain fields but can contain properties. Interfaces also cannot have static members.
    // When a child class inherits an interface, we say that it implements the interface.
    // One of the key differences between an abstract class and an interface is that a
    // class can only inherit one abstract class but can implement multiple interfaces.

    interface IShape
    {
        int MyNumber { get; set; } 
        void InterfaceMethod();
    }

    class ClassA : IShape
    {

        private int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("The number is {0}.", MyNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            Console.Read();
        }
    }
}
