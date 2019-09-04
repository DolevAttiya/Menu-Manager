using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateAction : IMenuAction
    {
        public void Perform()
        {
            string dateMessage = string.Format(
@"The date is: {0}
Press any key to continue...",
DateTime.Now.ToShortDateString());
            Console.WriteLine(dateMessage);
            Console.ReadLine();
        }
    }
}
