using BlackcombOS.System.Error;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using sfol = BlackcombOS.System;

namespace BlackcombOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine(" @@@@@@@@@ @@@@@@@@@     BlackComb OS\r\n @@@@@@@@@@@@@@@@@@@@    System Version 0.0.6\r\n @@@@@@@@@@@@@@@@@@@     Built on COSMOS.\r\n  @@@@@@@@@@@@@@@@@  \r\n  @@@@@@@@ @@@@@@@@  \r\n @@@ @@@@@@@@@@@@@@@ \r\n @@@@@@@@@@@    @@@@ \r\n@@ @@@@@@@@@    @@ @@\r\n@@@@@@@@@@@@@@  @@@@@\r\n@@@@@@@@@    @@@@@@@@\r\n @@@  @@@    @@   @@ \r\n  @@@ @@@@@@@@@  @@@ \r\n    @@@@@@@@@@@@@    \r\n       @@@@@@@       \r\n");
            Console.Write("Type text to get it echoed back.  ");
        }

        protected override void Run()
        {
            Console.Write("blackcomb@system:>");
            string input = Console.ReadLine();
            if (input.StartsWith("echo ")) { Console.WriteLine(input.Remove(0, 5)); }
            if (input.StartsWith("error "))
            {
                var c = new crash();
                c.Crash(input.Remove(0, 6));


            }
        }
    }
}