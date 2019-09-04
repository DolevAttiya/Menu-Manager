using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionAction : IMenuAction
    {
        public void Perform()
        {
            string ver = "19.3.4.42";
            string versionMessage = string.Format(
@"Version: {0}
Press any key to continue...", ver);

            Console.WriteLine(versionMessage);
            Console.ReadLine();
        }
    }
}
