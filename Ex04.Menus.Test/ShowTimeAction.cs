using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeAction : IMenuAction
    {
        public void Perform()
        {
            Console.WriteLine(
@"The time now is: {0:hh:mm:ss tt}
Press any key to continue...",
DateTime.Now);
            Console.ReadLine();
        }
    }
}
