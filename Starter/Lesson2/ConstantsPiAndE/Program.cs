using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsPiAndE
{ 
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141592653d;
            decimal e = 2.7182818284590452m;

            Console.WriteLine("pi = {0}", pi);
            Console.WriteLine("e = {0}", e);

            Console.ReadKey();
        }
    }
}
