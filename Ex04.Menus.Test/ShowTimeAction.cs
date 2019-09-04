using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeAction : IMenuAction
    {
        public void Perform()
        {
            string timeMessage = string.Format(
@"The time now is: {0:hh:mm:ss tt}
Press any key to continue...",
DateTime.Now);
            Console.WriteLine(timeMessage);
            Console.ReadLine();
        }
    }
}
