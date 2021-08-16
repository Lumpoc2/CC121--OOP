using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: falmark G. Lumpoc");
            Console.WriteLine("Section: BSCS A - 1");
            Console.ReadLine();
            int B, C;
            Console.Write("Enter the Side of Rectangle: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Height of Rectangle: ");
            C = Convert.ToInt32(Console.ReadLine());
            int Side = B * C;
            int Height = 2 / (B + C);
            Console.WriteLine("Area of Rectangle is = {0} and Perimeter is ={1}", Side, Height);
            Console.ReadKey();
        }
    }
}
