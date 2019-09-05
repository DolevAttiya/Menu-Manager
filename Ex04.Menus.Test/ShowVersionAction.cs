using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionAction : IMenuAction
    {
        public void Perform()
        {
            string version = "19.3.4.42";

            Console.WriteLine(
@"Version: {0}
Press any key to continue...", version);
            Console.ReadLine();
        }
    }
}
