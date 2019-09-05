using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateAction : IMenuAction
    {
        public void Perform()
        {
            Console.WriteLine(
@"The date is: {0}
Press any key to continue...",
DateTime.Now.ToShortDateString());
            Console.ReadLine();
        }
    }
}
