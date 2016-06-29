using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle(-10, -20, -20);
            Angle b = new Angle(220, 221, 221);

            Console.WriteLine(a.AbsoluteSeconds);
            Console.WriteLine("{0}, {1}, {2}",a.Degrees, a.Minutes, a.Seconds);
            Console.WriteLine("{0}, {1}, {2}", b.Degrees, b.Minutes, b.Seconds);
            Console.WriteLine("sum = {0}", a + b);
            Console.WriteLine("sub = {0}", a - b);

            Console.WriteLine("a == b: {0}", a == b);
            Console.WriteLine("a != b: {0}", a != b);
            Console.WriteLine("a > b: {0}", a > b);
            Console.WriteLine("a < b: {0}", a < b);

            Console.Read();
        }
    }
}
