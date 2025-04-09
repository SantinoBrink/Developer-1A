using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Opdract_Santino
{
    class Command
    {
        public string ID;
        public string ComandInfo;
        public static Action ExecuteComand;

        public Command(string iD, string comandInfo, Action executeComand)
        {
            ID = iD;
            ComandInfo = comandInfo;
            ExecuteComand = executeComand;
        }

        public void Execute()
        {
            ExecuteComand.Invoke();
        }
    }
}
