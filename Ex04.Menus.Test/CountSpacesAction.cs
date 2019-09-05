using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpacesAction : IMenuAction
    {
        public void Perform()
        {
            int amountOfSpaces = 0;
            string inputString;

            Console.WriteLine("Please enter a sentence To search for Spaces:");
            inputString = Console.ReadLine();
            foreach (char charInString in inputString)
            {
                if (char.IsWhiteSpace(charInString))
                {
                    amountOfSpaces++;
                }
            }

            Console.WriteLine(
@"There are {0} Spaces in the sentence
Press any key to continue...",
amountOfSpaces);
            Console.ReadLine();       
        }
    }
}
