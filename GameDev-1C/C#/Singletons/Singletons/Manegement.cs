using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletons
{
    class Manager
    {

        private static Manager instance;
        private Manager()
        {

        }

        public static Manager GetInstance()
        {
            if(instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }
    }
}
