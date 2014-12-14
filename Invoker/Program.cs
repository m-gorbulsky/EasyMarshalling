using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoker
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            Console.WriteLine("a = {0}", a);
            Imported.SetToOne(a);
            Console.WriteLine("a = {0}", a);

            Console.ReadLine();
        }
    }
}
