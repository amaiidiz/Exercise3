using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    interface Interface1
    {
        void PrintHello();
    }

    class print : Interface1
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello Interface");
        }
    }

}
