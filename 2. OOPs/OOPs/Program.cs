using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // Inheritance

    class Member
    {
        protected int annualFee;  // A protected field is a field that is only accessible within the class in which it is declared and any class that is derived from it.
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
            "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
            annualFee;
        }

        // constructors
        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }
        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");
            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        // method
        // The virtual keyword tells the compiler that this method may be overridden in derived classes.
        // When the compiler encounters this keyword, it’ll look for the same method in the derived class and execute that method instead
        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }

    // Writing the Child Class

    // Derived classes are known as child classes, 
    // while the classes from which they are derived are known as parent classes or base classes.
    // A derived class inherits all the public and protected members from the parent class
    // it can use those fields, properties and methods as if they are part of its own code
    // We indicate that it is derived from the Member class using a colon(:)

    class NormalMember : Member
    {
        // constructor of the child class - first way
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameters");
        }

        // The second way to declare a child constructor is to use the colon sign (:) 
        // and the base keyword to call a non parameterless constructor in the parent class


        // When we call a non parameterless constructor in the parent class, we need to pass in values to its parameters.
        //public NormalMember(string remarks) : base("Jamie", 1, 2015)
        //{
        //    Console.WriteLine("Remarks = {0}", remarks);
        //}


        // The first parameter is a string parameter called remarks.This parameter is used inside the child constructor.
        // The second, third and fourth parameters are not used in the child constructor.
        // Instead, they are passed in as arguments to the parent constructor based on their names
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with 4 parameters");
            Console.WriteLine("Remarks  = {0}", remarks);
        }
        // When we create a child object with this constructor, we write something like
        //NormalMember myChildMember = new NormalMember("Special Rate", "Evans", 1, 2023);

        // When you run the code, you will get the following output
        //Parent Constructor with 3 parameters
        //Child Constructor with 4 parameters
        //Remarks = Special Rate

        // method
        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }


    // Polymorphism
    // Polymorphism refers to a program’s ability to use the correct method for an object based on its runtime type

    class Program
    {
        static void Main(string[] args)
        {
            // inheritance
            //NormalMember mem1 = new NormalMember("Special Rate", "Evans", 1, 2012);
            //VIPMember mem2 = new VIPMember("Andy", 2, 2011);

            //mem1.CalculateAnnualFee();
            //mem2.CalculateAnnualFee();
            //Console.WriteLine(mem1.ToString());
            //Console.WriteLine(mem2.ToString());
            //Console.ReadLine();

            // Polymorphism
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1,2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
                Console.ReadLine();
            }

            // GetType() and typeof()
            // The GetType() method returns the runtime type of an object
            // The typeof() method takes the name of a data type (e.g. int, float, or the name of a class) 
            // and returns the type of that name, which we can then compare with the result of the GetType() method on the left.
            if (clubMembers[0].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
