using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionAction : IMenuAction
    {
        public void Perform()
        {
            string shownVersion = "19.3.4.42";

            Console.WriteLine(
@"Version: {0}
Press Enter to continue",
shownVersion);
            Console.ReadLine();
        }
    }
}
