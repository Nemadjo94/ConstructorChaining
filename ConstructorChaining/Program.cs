using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorChaining ctor = new ConstructorChaining();
            ctor.Dump();

            ConstructorChaining ctor2 = new ConstructorChaining("C:\\MyFolder\\Homework\\");
            ctor2.Dump();

        }
    }
}
