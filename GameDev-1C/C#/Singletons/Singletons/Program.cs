using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletons
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mijnManager = Manager.GetInstance();
        }
    }
}
