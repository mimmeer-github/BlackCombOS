using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackcombOS.System.Error
{
    internal class crash
    {
        public void Crash(string error)
        {
            Console.Clear();
            Console.WriteLine(" @@@@@@@@@ @@@@@@@@@\r\n @@@@@@@@@@@@@@@@@@@@\r\n @@@@@@@@@@@@@@@@@@@\r\n  @@@@@@@@@@@@@@@@@  \r\n  @@@@@@@@ @@@@@@@@  \r\n @@@ @@@@@@@@@@@@@@@ \r\n @@@@@@@@@@@    @@@@ \r\n@@ @@@@@@@@@    @@ @@\r\n@@@@@@@@@@@@@@  @@@@@\r\n@@@@@@@@@    @@@@@@@@\r\n @@@  @@@    @@   @@ \r\n  @@@ @@@@@@@@@  @@@ \r\n    @@@@@@@@@@@@@    \r\n       @@@@@@@       \r\n");
            Console.WriteLine("A fatal system error has occured and BlackComb OS has been shut down to prevent damage to your computer.\r\nExeption: ", error, ".\r\nIf you figure out a way to get support give them this info: \r\nSystem version: 0.0.6\r\nRebuild no: 6");
        }
    }
}