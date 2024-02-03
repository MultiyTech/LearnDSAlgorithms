using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms
{
    internal class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("I am your child");
        }

        public static void Main()
        {
            Child c = new Child();
            Console.ReadKey();
        }
    }


}
