using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneEx
{
    class Program
    {
        private static void Foo(in string prototype_str) // in means const-like value
        {
            //prototype_str = prototype_str + "junk!";
        }
        private static void Foo_2(in Employee prototype_emp) // in means const-like value
        {
            prototype_emp.Age = 20;
            //prototype_emp = null;
        }

        private static void Foo_3(Employee prototype_emp)
        {
            Console.WriteLine(prototype_emp.Age);
            prototype_emp = new Employee() ;
            Console.WriteLine(prototype_emp.Age);
        }

        public class Employee
        {
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            string protect_me = "itay";
            Foo(protect_me);
            Console.WriteLine(protect_me);

            Employee e = new Employee() { Age = 22 };
            Foo_2(e);
            Console.WriteLine(e.Age);

            Foo_3(e);
            Console.WriteLine(e.Age);
            int x = 5;

        }
    }
}
