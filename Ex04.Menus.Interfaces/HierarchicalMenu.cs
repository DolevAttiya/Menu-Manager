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
        private const string k_Separator = "###################################";
        private readonly List<MenuItem> r_AttachedItems;

        public HierarchicalMenu(string i_Topic)
        {
            r_AttachedItems = new List<MenuItem>();
            Topic = i_Topic;
        }

        public List<MenuItem> AttachedItems
        {
            get { return r_AttachedItems; }
        }

        public void AddItemToList(MenuItem i_ItemToAdd)
        {
            bool isFirstItem = AttachedItems.Count == 0;

            if (isFirstItem)
            {
                MenuAction backItem = new MenuAction();
                AttachedItems.Add(backItem);
                AttachedItems[k_GoToUpperMenuIndex].Topic = k_GoToUpperMenuTopic;
            }

            i_ItemToAdd.PlaceOfItem = AttachedItems.Count;
            AttachedItems.Add(i_ItemToAdd);
        }

        private void printMenuList()
        {
            string itemListToPrint = string.Format("{0}. {1}", AttachedItems[0].PlaceOfItem, AttachedItems[0].Topic);
            Console.WriteLine(itemListToPrint);

            for (int i = 1; i < AttachedItems.Count; i++)
            {
                itemListToPrint = string.Format("{0}. {1}", AttachedItems[i].PlaceOfItem, AttachedItems[i].Topic);
                Console.WriteLine(itemListToPrint);
            }
        }

        private void showMenu()
        {
            int userChoice;

            do
            {
                Console.WriteLine(Topic);
                Console.WriteLine(k_Separator);
                Console.WriteLine("Choose one options:");
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
                Console.WriteLine("Invalid Input. Please enter number in range (of the above options):");
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