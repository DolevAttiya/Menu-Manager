﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class HierarchicalMenu : MenuItem
    {
        private const string k_GoToUpperMenuTopic = "Back";
        private const int k_GoToUpperMenuIndex = 0;
        private readonly List<MenuItem> r_AttachedItems;

        public HierarchicalMenu(string i_MenuTopic)
        {
            Topic = i_MenuTopic;
            r_AttachedItems = new List<MenuItem>();
            MenuItem GoBackMenu = new MenuItem();
            AttachedItems.Add(GoBackMenu);
            AttachedItems[k_GoToUpperMenuIndex].Topic = k_GoToUpperMenuTopic;
        }

        public List<MenuItem> AttachedItems
        {
            get { return r_AttachedItems; }
        }

        public void AddItemToList(MenuItem i_ItemToAttach)
        {
            i_ItemToAttach.PlaceOfItem = AttachedItems.Count;
            AttachedItems.Add(i_ItemToAttach);
        }

        private void printMenuList()
        {
            foreach (MenuItem itemToPrint in AttachedItems)
            {
                Console.WriteLine("{0}. {1}", itemToPrint.PlaceOfItem, itemToPrint.Topic);
            }
        }

        private void getUserSelectedChoice(out int userSelectedChoice)
        {
            string userInput;
            
            Console.WriteLine("Please pick your one of the following selections by number Press 0 to Exit or to go Back :");
            printMenuList();
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out userSelectedChoice) || userSelectedChoice > AttachedItems.Count - 1 || userSelectedChoice < 0)
            {
                Console.WriteLine("Invalid Input.Please pick your one of the following selections by number 0 to {0}:", AttachedItems.Count - 1);
                printMenuList();

                userInput = Console.ReadLine();
            }
        }

        public void MenuDisplay()
        {
            int userSelectedChoice;

            do
            {
                Console.Clear();
                Console.WriteLine(this.Topic);
                foreach (char underLinePrinter in this.Topic)
                {
                    Console.Write("═");
                }

                Console.WriteLine(Environment.NewLine);
                getUserSelectedChoice(out userSelectedChoice);
                HierarchicalMenu choosenMenu = r_AttachedItems[userSelectedChoice] as HierarchicalMenu;

                Console.Clear();
                if (choosenMenu == null)
                {
                    AttachedItems[userSelectedChoice].DoAction();
                }
                else
                {
                    choosenMenu.MenuDisplay();
                }
            }
            while (userSelectedChoice != k_GoToUpperMenuIndex);
        }      
    }
}