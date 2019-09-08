using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateAction : IMenuAction
    {
        public void Perform()
        {
            Console.WriteLine(
@"The Current Date is: {0}
Press Enter To Continue",
DateTime.Now.ToShortDateString());
            Console.ReadLine();
        }
    }
}
