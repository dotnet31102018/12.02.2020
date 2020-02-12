using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneEx
{
    class Program
    {
        public struct Point : ICloneable
        {
            // public int X = 1;// cannot declare values ubnless const or static
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            //public Point()
            //{
            //
            //}
            public static Point operator +(Point x)
            {
                return new Point(3, 3);
            }
            public override string ToString()
            {
                return $"{X} {Y}";
            }

            public object Clone()
            {
                throw new NotImplementedException();
            }
        }

        static void Changeme(Point p) // auto clone
        {
            p.X = 12;
            p = new Point(5, 5);
        }
        static void ChangemeWithRef(ref Point p) // auto clone
        {
            p.X = 12;
            p = new Point(5, 5);
        }
        static void Change(ref int x)
        {
            x = 4;
        }
        public class Employee
        {
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            //Point? p = new Point() { X = 1};
            //p = null;
            Point p = new Point(6, 8);
            Changeme(p);
            Console.WriteLine(p.X);

            int x = 2;
            Change(ref x);
            Console.WriteLine(x);

            Point p1 = new Point(1, 2);
            Point p2 = p1;
            Console.WriteLine(p1.Equals(p2)); // true
            p1.X = 12;
            Console.WriteLine(p2.X); // 1
            Console.WriteLine(p1.Equals(p2)); // false

            Employee e1 = new Employee() { Age = 20 };
            Employee e2 = e1;
            e1.Age = 30;
            Console.WriteLine(e2.Age); // 30

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(1.GetHashCode());

        }
    }
}
