using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpacesAction : IMenuAction
    {
        public void Perform()
        {
            int amountOfSpaces = 0;
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();

            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    amountOfSpaces++;
                }
            }

            string message = string.Format(
@"There are {0} Spaces in the sentence
Press any key to continue...", 
amountOfSpaces);

            Console.WriteLine(message);
            Console.ReadLine();       
        }
    }
}
