using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class HierarchicalMenu : MenuItem
    {
        private const int k_GoToUpperMenuIndex = 0;
        private const string k_GoToUpperMenuTopic = "Back";
        private readonly List<MenuItem> r_AttachedItems;

        public HierarchicalMenu(string i_Topic)
        {
            r_AttachedItems = new List<MenuItem>();
            Topic = i_Topic;
            MenuAction backItem = new MenuAction();
            AttachedItems.Add(backItem);
            AttachedItems[k_GoToUpperMenuIndex].Topic = k_GoToUpperMenuTopic;
        }

        public List<MenuItem> AttachedItems
        {
            get { return r_AttachedItems; }
        }

        public void AddItemToList(MenuItem i_ItemToAdd)
        {
            i_ItemToAdd.PlaceOfItem = AttachedItems.Count;
            AttachedItems.Add(i_ItemToAdd);
        }

        private void printMenuList()
        {
            foreach (MenuItem itemToPrint in AttachedItems)
            {
                Console.WriteLine("{0}. {1}", itemToPrint.PlaceOfItem, itemToPrint.Topic);
            }
        }

        private void showMenu()
        {
            int userChoice;

            do
            {
                Console.WriteLine(Topic);
                foreach (char underLinePrinter in this.Topic)
                {
                    Console.Write("═");
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Please pick your one of the following selections by number Press 0 to Exit or to go Back :");
                printMenuList();
                userChoice = getUserSelectedChoice();
                Console.Clear();
                if (userChoice != k_GoToUpperMenuIndex)
                {
                    AttachedItems[userChoice].Show();
                }
            }
            while (userChoice != k_GoToUpperMenuIndex);
        }

        private int getUserSelectedChoice()
        {
            int userChoice;
            string userChoiceByString = Console.ReadLine();

            while (!int.TryParse(userChoiceByString, out userChoice) ||
                (userChoice < 0 || userChoice > AttachedItems.Count - 1))
            {
                Console.WriteLine("Invalid Input.Please pick your one of the following selections by number 0 to {0}:", AttachedItems.Count - 1);
                printMenuList();
                userChoiceByString = Console.ReadLine();
            }

            return userChoice;
        }

        public override void Show()
        {
            if (AttachedItems.Count == 0)
            {
                MenuAction backItem = new MenuAction();
                AttachedItems.Add(backItem);
                AttachedItems[k_GoToUpperMenuIndex].Topic = k_GoToUpperMenuTopic;
            }

            showMenu();
        }
    }
}