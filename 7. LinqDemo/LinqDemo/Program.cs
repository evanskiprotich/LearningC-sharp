using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    // LINQ
    // LINQ stands for Language-Integrated Query
    // allows you to query data in your program
    // The typical syntax for a LINQ query
    // from… where… orderby… select

    //var is a special data type that we use whenever we want the complier to determine the data type itself.
    //This is necessary because in our example below, the data type of evenNumQuery is quite complex; 
    //we are better off letting C# figure the data type out for us.

    class Customer
    {
        public string Name;
        public string Phone;
        public string Address;
        public decimal Balance;

        public Customer(string Name, string Phone, string Address, decimal Balance)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
            this.Balance = Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ EXAMPLE
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNumQuery)
            {
                Console.WriteLine("{0} is an even number", i);
                Console.ReadLine();
            }

            // object
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
            customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.2m));
            customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

            // LINQ Query
            var overdue =
                from cust in customers
                where cust.Balance < 0
                orderby cust.Balance ascending
                select new { cust.Name, cust.Balance };

            foreach (var cust in overdue)
                Console.WriteLine("Name = {0}, Balance = {1}", cust.Name,
                cust.Balance);
            Console.ReadLine();
        }
    }
}
