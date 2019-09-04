using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private const int k_BackItemIndex = 0;
        private const string k_BackItemTitle = "Back";
        private const string k_Separator = "###################################";
        //private const string k_Separator = "===========================================";
        private readonly List<MenuItem> r_ItemList;

        public SubMenu(string i_Title)
        {
            r_ItemList = new List<MenuItem>();
            Title = i_Title;
        }

        public List<MenuItem> ItemList
        {
            get { return r_ItemList; }
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            bool isFirstItem = ItemList.Count == 0;

            if (isFirstItem)
            {
                MenuAction backItem = new MenuAction();
                ItemList.Add(backItem);
                ItemList[k_BackItemIndex].Title = k_BackItemTitle;
            }

            i_ItemToAdd.ItemIndex = ItemList.Count;
            ItemList.Add(i_ItemToAdd);
        }

        private void printMenuItemList()
        {
            string itemListToPrint = string.Format("{0}. {1}", ItemList[0].ItemIndex, ItemList[0].Title);
            Console.WriteLine(itemListToPrint);

            for (int i = 1; i < ItemList.Count; i++)
            {
                itemListToPrint = string.Format("{0}. {1}", ItemList[i].ItemIndex, ItemList[i].Title);
                Console.WriteLine(itemListToPrint);
            }
        }

        private void showMenu()
        {
            int userChoice;

            do
            {
                Console.WriteLine(Title);
                Console.WriteLine(k_Separator);
                Console.WriteLine("Choose one options:");
                printMenuItemList();
                userChoice = getUserChoice();
                Console.Clear();
                if (userChoice != k_BackItemIndex)
                {
                    ItemList[userChoice].Show();
                }
            }
            while (userChoice != k_BackItemIndex);
        }

        private int getUserChoice()
        {
            int userChoice;
            string userChoiceByString = Console.ReadLine();

            while (!int.TryParse(userChoiceByString, out userChoice) ||
                (userChoice < 0 || userChoice > ItemList.Count - 1))
            {
                Console.WriteLine("Invalid Input. Please enter number in range (of the above options):");
                userChoiceByString = Console.ReadLine();
            }

            return userChoice;
        }

        public override void Show()
        {
            if (ItemList.Count == 0)
            {
                MenuAction backItem = new MenuAction();
                ItemList.Add(backItem);
                ItemList[k_BackItemIndex].Title = k_BackItemTitle;
            }

            showMenu();
        }
    }
}